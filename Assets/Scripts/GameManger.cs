using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    //to whoever marks this please explain why this dosent sort the vlaues properly 
    
    public Target[] targets;
    

    

    void Start()
    {
        
        targets = FindObjectsOfType<Target>();  // finds the object target
   
        BubbleSort();  // runs the bubble sort

        for (int i = 0; i < targets.Length; i++)   // Print the sorted HP values for debugging
        {
            Debug.Log("Target " + (i + 1) + " HP: " + targets[i]);
        }

    }

   void BubbleSort()
    {
        int n = targets.Length;
        for (int i = 0;i < n - 1;i++)
        { 
            for(int j = 0;j < n - i - 1;j++)
            {
                if (targets[j].GetHP() < targets[j + 1].GetHP())
                {
                    Target temp = targets[j];
                    targets[j] = targets[j + 1];
                    targets[j + 1] = temp;
                }
            }
        }
                
    }

    

    public Target[] SortedHP()
    {
        return targets;
    }
}

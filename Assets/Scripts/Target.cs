using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
    
{
    
    [SerializeField] private int HP; // set HP in inspector

    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(HP);
        

    }
    public int GetHP()
    {
        return HP;
    }

}

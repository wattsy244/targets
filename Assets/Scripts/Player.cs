//using UnityEditor.Build.Content;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
//Error building caused by this top part ^^ 

public class Player : MonoBehaviour
{
    private GameManager gameManager;
    private Target[] targets;
    private int currentIndex = 3;
    [SerializeField] private Camera playerCamera;
    
    

    
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();  // finds the game manager
        targets = gameManager.SortedHP(); // finds the object Target
        FaceNext(); // runs FaceNext()
        

    }
     void Update()
    {
        if(Input.GetKeyDown(KeyCode.A)) // runs FaceNext() when A is pressed
        {
            FaceNext();

        }


     }
    private void FaceNext()
    {
        int targetCount = targets.Length; //loads the target length from game manager


        for (int j = 0; j < targetCount; j++)
        {
            currentIndex = (currentIndex + 1) % targetCount;
            Target target = targets[currentIndex]; // loads the current index of targets

            playerCamera.transform.LookAt(target.transform); // changes camera to face a different target
            return;
        }


        //Debug.Log("no targets");
    }

}

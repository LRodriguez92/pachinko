using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeTracker : MonoBehaviour
{

    public int lives;
    public Text livesText;
    public GameObject iconPrefab;

    private float xPosition;
    private float yPosition;
    private float zPosition;
    private GameObject spawnedObject;   
    
    // private float[] deletedIconPositions; // Keeps track of x position of deleted icons
    // private float deletedIconX;

    // void Start()
    // {

    //     deletedIconPositions = new float[lives]; // Initialize array with the amount of items expected (lives)

    //     for (int i = 0; i < lives; i++)
    //     {
    //         Debug.Log("Looping");
    //         spawnedObject = Instantiate(iconPrefab) as GameObject;

    //         xPosition = spawnedObject.transform.position.x;
    //         yPosition = spawnedObject.transform.position.y;
    //         zPosition = spawnedObject.transform.position.z;
            
    //         if (i >= 5)
    //         {
    //             // Forms a new row after 5 Icons
    //             spawnedObject.transform.position = new Vector3(xPosition + .5f * (i - 5), yPosition - .5f, zPosition);
    //         }
    //         else{
    //             spawnedObject.transform.position = new Vector3(xPosition + .5f * i, yPosition, zPosition);
    //         }
    //     }
    // }
    
    public void DecreaseLives(int livesToSubtract) 
    {
        
        lives -= livesToSubtract;

        // GameObject icon = GameObject.Find("LifeIcon(Clone)");


        // float deletedIconX = icon.transform.position.x; //Finds position of last icon found
        // deletedIconPositions[10 - lives] = deletedIconX; // Adds x pos before getting deleted
        // Debug.Log("Current deleted icon positions: " + deletedIconPositions[0]);
        
        
        // Destroy(icon);


        if (lives <= 0)
        {
           livesText.text = "Out of Balls!";
        }
        else
        {
            Debug.Log("Lives left: " + lives);
            livesText.text = "LIVES: " + lives;
        }

    }

    public void IncreaseLives(int livesToAdd)
    {
        Debug.Log("Adding life!");
        
        lives += livesToAdd;

        livesText.text = "LIVES: " + lives;

        // spawnedObject = Instantiate(iconPrefab) as GameObject;

        // int index = deletedIconPositions.Length - lives;
        // Debug.Log("Current Index: " + index);
        // Debug.Log("Deleted icon:" + deletedIconPositions[index]);

        // spawnedObject.transform.position = new Vector3(deletedIconPositions[index], yPosition, zPosition);
    }
}

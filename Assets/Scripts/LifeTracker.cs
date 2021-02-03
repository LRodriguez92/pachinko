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
    
    
    public void DecreaseLives(int livesToSubtract) 
    {
        
        lives -= livesToSubtract;

        if (lives <= 0)
        {
           livesText.text = "Out of Balls!";
        }
        else
        {
            livesText.text = "LIVES: " + lives;
        }

    }

    public void IncreaseLives(int livesToAdd)
    {
        
        lives += livesToAdd;

        livesText.text = "LIVES: " + lives;

    }

    public int GetLives()
    {
        return lives;
    }
}

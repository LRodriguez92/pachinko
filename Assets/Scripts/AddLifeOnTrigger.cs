using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddLifeOnTrigger : MonoBehaviour
{
    public int livesToAdd;
    public LifeTracker lifeTracker;

    void OnTriggerEnter2D(Collider2D collision)
    {
        lifeTracker.IncreaseLives(livesToAdd);
    } 
}

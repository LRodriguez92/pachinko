using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddLifeOnTrigger : MonoBehaviour
{
    public int livesToAdd;
    public LifeTracker lifeTracker;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ball")
        {
            lifeTracker.IncreaseLives(livesToAdd);
            Destroy(collision.gameObject);
        }
    } 
}

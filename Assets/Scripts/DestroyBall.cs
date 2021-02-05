using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBall : MonoBehaviour
{
    public LifeTracker lifeTracker;
    public GameController gameController;

    private int lives;
    private int ballCount;

    public void Update()
    {
        lives = lifeTracker.GetLives();
        ballCount = GameObject.FindGameObjectsWithTag("Ball").Length;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ball" && lifeTracker != null)
        {
            Destroy(collision.gameObject);

            if(lives <= 0 && ballCount <= 1) // Can't get triggered if 0 balls exist
            {
                Debug.Log("You Lose!");
                gameController.GameOver();
            }
        }
        else if (collision.tag == "Ball")
        {
            Destroy(collision.gameObject);
        }
    }
}

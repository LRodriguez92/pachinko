using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBall : MonoBehaviour
{
    public LifeTracker lifeTracker;
    public GameController gameController;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ball" && lifeTracker != null)
        {
            Destroy(collision.gameObject);

            if(lifeTracker.GetLives() <= 0)
            {
                gameController.GameOver();
            }
        }
        else if (collision.tag == "Ball")
        {
            Destroy(collision.gameObject);
        }
    }
}

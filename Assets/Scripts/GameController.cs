using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    //public LifeTracker lifeTracker;
    public GameObject gameOverScreen;

    // Start is called before the first frame update
    void Start()
    {
        gameOverScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //if (lifeTracker == null)
        //{
        //    return;
        //}

        //if (lifeTracker.GetLives() <= 0)
        //{
        //    gameOverScreen.SetActive(true);
        //}
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

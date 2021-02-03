using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    //public LifeTracker lifeTracker;
    public GameObject gameOverScreen;

    private int platformCount;

    // Start is called before the first frame update
    void Start()
    {
        gameOverScreen.SetActive(false);

        platformCount = GameObject.FindGameObjectsWithTag("Platform").Length;
    }

    // Update is called once per frame
    void Update()
    {
        platformCount = GameObject.FindGameObjectsWithTag("Platform").Length;

        if (platformCount <= 0)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public int GetPlatformCount()
    {
        return platformCount;

    }

}

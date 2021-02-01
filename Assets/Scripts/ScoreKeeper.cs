using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    public int score;
    public Text scoreText;
    
    public void AddScore(int scoreToAdd)
    {
        score += scoreToAdd;

        scoreText.text = "SCORE: " + score;
    }

}

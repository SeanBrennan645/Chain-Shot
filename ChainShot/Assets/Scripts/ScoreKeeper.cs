using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    [SerializeField] Text scoreText;
    private int score = 0;

    private void Start()
    {
        scoreText.text = "Score: 0";
    }

    public void IncreaseScore(int points)
    {
        score += points;
        scoreText.text = "Score: " + score;
    }
}

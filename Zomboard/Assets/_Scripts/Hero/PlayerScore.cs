using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    public TMP_Text scoreNum;
    public int playerScore = 0;

    public static PlayerScore Instance;

    [HideInInspector]
    public int score;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(this);
    }
    private void Start()
    {
        playerScore = ScoreContainer.Score;
    }

    public void AddScore(int score)
    {
        playerScore += score;
        UpdateScore();
    }

    public void UpdateScore()
    {
        if (scoreNum == null)
        {
            Debug.LogWarning("No scoreNum found on this script, attach one on it!");
            return;
        }
        scoreNum.text = playerScore.ToString();
    }
}

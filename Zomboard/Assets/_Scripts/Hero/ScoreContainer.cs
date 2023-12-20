using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ScoreContainer
{
    public static int Score;

    public static void ResetScore()
    {
        Score = 0;
        Debug.Log("Reset score");
    }
}

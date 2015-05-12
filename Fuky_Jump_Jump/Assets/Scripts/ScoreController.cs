using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreController : MonoSingleton<ScoreController> {

    public Text textScore;

    public void ShowScore(int score)
    {
        textScore.text = "Score: " + score;
    }
}

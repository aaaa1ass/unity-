using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] Text scoreText;

    void Start()
    {
        scoreText.text = 
            "Best Score : " + DataManager.instance.BestScore + "\n"
            + "Score : 0";

    }
    public void IncreaseScore()
    {
        DataManager.instance.Score += 100;

        DataManager.instance.BestScoreCheck();

        scoreText.text =
            "Best Score : " + DataManager.instance.BestScore + "\n"
            + "Score : " + DataManager.instance.Score;

        DataManager.instance.Save();
    }
}

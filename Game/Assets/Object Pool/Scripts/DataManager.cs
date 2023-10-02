using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    private int score;
    private int best_score;
    public int Score 
    { 
        get { return score; }
        set { score = value; }
    }

    public int BestScore
    {
        get { return best_score; }
        set { best_score = value; }
    }

    public static DataManager instance;
    void Awake()
    {
        Load();

        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        score = 0;
    }
    public void BestScoreCheck()
    {
        if(score>best_score)
        {
            best_score = score;
        }
    }
    public void IncreaseScore()
    {
        score += 100;
    }
    public void Save()
    {
        PlayerPrefs.SetInt("SCORE",best_score);
    }
    public void Load()
    {
        best_score = PlayerPrefs.GetInt("SCORE");
    }
}

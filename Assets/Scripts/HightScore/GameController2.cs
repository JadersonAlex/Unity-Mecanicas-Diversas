using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameController2 : MonoBehaviour
{
    public static GameController2 instance2;

    [Header("Variáveis")]
    public TMP_Text scoreText;
   // public TMP_Text HighScoreText;
    public int HightScore;
    public int Score;

    void Start()
    {
        if (instance2 == null) // se o instance não existir
        {
            instance2 = this;
            DontDestroyOnLoad(instance2);
        }
        else  // se for nulo
        {
            Destroy(gameObject);
        }

        HightScore = PlayerPrefs.GetInt("HightScore");
       


    }
    public int AddScore(int score)
    {
        Score += score;
        scoreText.text = Score.ToString();
        Record();
        return Score;
    }


    public void Record()
    {
        PlayerPrefs.SetInt("HightScore", Score);
        
        if (PlayerPrefs.GetInt("HightScore") < Score)
        {
            //salvo novo score
            PlayerPrefs.SetInt("HightScore", Score);
            HightScore = Score;
            
        }
        else
        {
            //record não foi batido
        }
    }
}

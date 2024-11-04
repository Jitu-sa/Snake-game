using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UIElements;

public class InGameScoreManager : MonoBehaviour
{
    public int Score;
    int highscore;
    [SerializeField] GameObject Snake_Body;
    [SerializeField] TextMeshProUGUI ScoreText;

    void Update()
    {
        ScoreText.text=Score.ToString();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Food")
        {
            Score++;
            Spawn_Snake_Body();
        }

        else
        {
            savefinalscore();
        }
    }

    void Spawn_Snake_Body()
    {
        int TargetName = Score - 1;
        GameObject Target = GameObject.Find(TargetName.ToString());
        Instantiate(Snake_Body,Target.transform.position, new Quaternion(0, 0, 0, 0));
    }

    void savefinalscore()
    {
        PlayerPrefs.SetInt("finalscore", Score);
        if (Score > PlayerPrefs.GetInt("highscore", 0))
        {
            highscore = Score;
            PlayerPrefs.SetInt("highscore", highscore);
        }
    }
}

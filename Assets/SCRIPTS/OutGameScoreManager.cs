using UnityEngine;
using TMPro;

public class OutGameScoreManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI ScoreText;
    [SerializeField] TextMeshProUGUI highScoreText;
    [SerializeField] int finalscore;
    [SerializeField] int highscore;

    void Start()
    {
        finalscore = PlayerPrefs.GetInt("finalscore", 0);
        highscore = PlayerPrefs.GetInt("highscore", 0);
        ScoreText.text = finalscore.ToString();
        highScoreText.text = highscore.ToString();
    }
}

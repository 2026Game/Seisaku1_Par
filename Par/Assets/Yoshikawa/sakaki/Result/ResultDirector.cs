using UnityEngine;
using TMPro;

public class ResultDirector : MonoBehaviour
{
    GameObject resultPanel;

    GameObject scoreText;
    GameObject hpText;
    GameObject timeText;

    bool isResult = false;

    void Start()
    {
        resultPanel = GameObject.Find("ResultPanel");

        scoreText = GameObject.Find("ScoreText");
        hpText = GameObject.Find("HPText");
        timeText = GameObject.Find("TimeText");

        resultPanel.SetActive(false);
    }

    void Update()
    {
        if (!isResult && GameDirector.stop == 0)
        {
            isResult = true;

            resultPanel.SetActive(true);

            scoreText.GetComponent<TextMeshProUGUI>().text =
                "SCORE : " + GameDirector.score;

            hpText.GetComponent<TextMeshProUGUI>().text =
                "HP : " + HPDirector.HP;

            timeText.GetComponent<TextMeshProUGUI>().text =
                "TIME : "
                + GameDirector.hour + ":"
                + GameDirector.minute + ":"
                + GameDirector.retime;
        }
    }
}
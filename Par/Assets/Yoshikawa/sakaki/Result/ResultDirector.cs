using UnityEngine;
using TMPro;

public class ResultDirector : MonoBehaviour
{
    public GameObject resultPanel;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI hpText;
    public TextMeshProUGUI timeText;

    bool isResult = false;

    void Update()
    {
        if (!isResult && GameDirector.stop == 0)
        {
            isResult = true;

            resultPanel.SetActive(true);

            scoreText.text = "SCORE : " + GameDirector.score;
            hpText.text = "HP : " + HPDirector.HP;
            timeText.text =
                "TIME : "
                + GameDirector.hour + ":"
                + GameDirector.minute + ":"
                + GameDirector.retime;
        }
    }
}
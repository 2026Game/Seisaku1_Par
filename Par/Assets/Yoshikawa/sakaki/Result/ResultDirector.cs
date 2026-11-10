using UnityEngine;

public class ResultDirector : MonoBehaviour
{
    GameObject resultPanel;
    bool isResult = false;

    void Start()
    {
        resultPanel = GameObject.Find("ResultPanel");
        resultPanel.SetActive(false);
    }

    void Update()
    {
        if (!isResult &&
            (GameDirector.hour >= 6 || HPDirector.HP <= 0))
        {
            Debug.Log("Œ‹‰ÊðŒ¬—§");
            isResult = true;
            resultPanel.SetActive(true);
        }
    }
}
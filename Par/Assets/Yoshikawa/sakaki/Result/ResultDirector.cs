using UnityEngine;

public class ResultDirector : MonoBehaviour
{
    // Inspectorからリザルトパネルを紐付ける
    public GameObject resultPanel;

    // すでにリザルトを表示したかどうかのフラグ
    bool isResultShown = false;

    void Start()
    {
        // ゲーム開始時はリザルトパネルを非表示にしておく
        if (resultPanel != null)
        {
            resultPanel.SetActive(false);
        }
    }

    void Update()
    {
        // すでに表示済みなら何もしない
        if (isResultShown) return;

        // GameDirectorのhourとHPDirectorのHPを直接監視する
        if (GameDirector.hour == 6 || HPDirector.HP <= 0)
        {
            ShowResult();
        }
    }

    void ShowResult()
    {
        isResultShown = true;

        if (resultPanel != null)
        {
            resultPanel.SetActive(true);
        }
    }
}
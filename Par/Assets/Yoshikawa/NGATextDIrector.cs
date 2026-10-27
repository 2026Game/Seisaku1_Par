using UnityEngine;
using TMPro;

public class NGATextDIrector : MonoBehaviour
{
    GameObject NGAtext;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.NGAtext = GameObject.Find("NGAText");
    }

    // Update is called once per frame
    void Update()
    {
        this.NGAtext.GetComponent<TextMeshProUGUI>().text =
                  GhostDirector.NGAretime.ToString();
    }
}

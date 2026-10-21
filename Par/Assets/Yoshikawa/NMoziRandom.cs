using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class MoziRandom : MonoBehaviour
{
    GameObject RandomText;
   public static int ascii;
    int randomtime = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.RandomText = GameObject.Find("GetRandomLette");
    }

    // Update is called once per frame
    void Update()
    {
        randomtime++;
        if (randomtime == 100)
        {
            ascii = Random.Range(65, 69); // A(65) Å` Z(90)
            this.RandomText.GetComponent<TextMeshProUGUI>().text =
                       ((char)ascii).ToString();
            randomtime = 0;
        }
    }
}

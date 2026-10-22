using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class MoziRandom : MonoBehaviour
{
    GameObject RandomText;
   public static int ascii;
    int randomtime = 0;
    int Rstop = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.RandomText = GameObject.Find("GetRandomLette");
    }

    // Update is called once per frame
    void Update()
    {
        randomtime+=1*Rstop;
        if (randomtime == 500)
        {
            ascii = Random.Range(30, 91); // A(65) Å` Z(90)
            this.RandomText.GetComponent<TextMeshProUGUI>().text =
                       ((char)ascii).ToString();
            randomtime = 0;
        }
        if(GameDirector.hour==6)
        {
            Rstop = 0;
        }
    }
}

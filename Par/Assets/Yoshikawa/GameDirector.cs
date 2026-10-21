using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class GameDirector : MonoBehaviour
{
    GameObject scoreText;
    GameObject timerText;
    GameObject minuteText;
    GameObject hourText;
    GameObject NGA;
    public GhostDirector GD;
    public NGhostDirectorB GDB;
    public static int miss = 0;
   public static int score = 0;
    float time = 0;
    static int retime;
    int minute = 0;
    int hour = 0;
    int stop = 1;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.scoreText = GameObject.Find("Score");
        this.timerText = GameObject.Find("Time");
        this.minuteText = GameObject.Find("Minute");
        this.hourText = GameObject.Find("Hour");
        this.NGA = GameObject.Find("NGA");
    }

    // Update is called once per frame
    void Update()
    {
        this.time += Time.deltaTime*stop;
        retime = (int)time;
        this.timerText.GetComponent<TextMeshProUGUI>().text =
                   retime.ToString();
        this.minuteText.GetComponent<TextMeshProUGUI>().text =
                  ":"+minute.ToString();
        this.hourText.GetComponent<TextMeshProUGUI>().text =
                   hour.ToString();

        this.scoreText.GetComponent<TextMeshProUGUI>().text =
           "SCR:"+score.ToString();

        if(retime==10)
        {
            time = 0;
            minute++;
        }

        if(minute==6)
        {
            minute = 0;
            hour++;
        }

        if(hour==6)
        {
            stop = 0;
        }

        
        if (GhostDirector.missA == 1 && GhostDirector.Aobake == 0)
        {
            GhostDirector.missA = 0;
            GhostDirector.Aobake = 1;
            if (GhostDirector.missA == 0)
            {
                GhostDirector.missA = 1;
            }

        }
        else if (NGhostDirectorB.missB == 1 && NGhostDirectorB.Bobake == 0)
        {
            NGhostDirectorB.missB = 0;
            NGhostDirectorB.Bobake = 1;
            if (NGhostDirectorB.missB == 0)
            {
                NGhostDirectorB.missB = 1;
            }
        }
        else if (NGhostDirectorC.missC == 1 && NGhostDirectorC.Cobake == 0)
        {
            NGhostDirectorC.missC = 0;
            NGhostDirectorC.Cobake = 1;
            if (NGhostDirectorC.missC == 0)
            {
                NGhostDirectorC.missC = 1;
            }
        }
        else if (NGhostDirectorD.missD == 1 && NGhostDirectorD.Dobake == 0)
        {
            NGhostDirectorD.missD = 0;
            NGhostDirectorD.Dobake = 1;
            if (NGhostDirectorD.missD == 0)
            {
                NGhostDirectorD.missD = 1;
            }
        }




    }
}

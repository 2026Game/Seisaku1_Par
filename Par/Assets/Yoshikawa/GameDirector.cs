using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class GameDirector : MonoBehaviour
{
    GameObject scoreText;
    GameObject timerText;
    GameObject minuteText;
    GameObject hourText;
    public GhostDirector GD;
    public NGhostDirectorB GDB;
    public static int miss = 0;
   public static int score = 0;
    float time = 0;
    static int retime;
    public static int minute = 0;
    public static int hour = 0;
    int stop = 1;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.scoreText = GameObject.Find("Score");
        this.timerText = GameObject.Find("Time");
        this.minuteText = GameObject.Find("Minute");
        this.hourText = GameObject.Find("Hour");
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

        if(Input.GetKeyDown(KeyCode.A) && GhostDirector.a == 0)
        {
            score -= 50;
        }
        else
        {
            GhostDirector.a = 0;
        }
        if (Input.GetKeyDown(KeyCode.B) && NGhostDirectorB.b == 0)
        {
            score -= 50;
        }
        else
        {
            NGhostDirectorB.b = 0;
        }
        if (Input.GetKeyDown(KeyCode.C) && NGhostDirectorC.c == 0)
        {
            score -= 50;
        }
        else
        {
            NGhostDirectorC.c = 0;
        }
        if (Input.GetKeyDown(KeyCode.D) && NGhostDirectorD.d == 0)
        {
            score -= 50;
        }
        else
        {
            NGhostDirectorD.d = 0;
        }
        if (Input.GetKeyDown(KeyCode.E) && NGhostDirectorE.e == 0)
        {
            score -= 50;
        }
        else
        {
            NGhostDirectorE.e = 0;
        }
        if (Input.GetKeyDown(KeyCode.F) && NGhostDirectorF.f == 0)
        {
            score -= 50;
        }
        else
        {
            NGhostDirectorF.f = 0;
        }
        if (Input.GetKeyDown(KeyCode.G) && NGhostDirectorG.g == 0)
        {
            score -= 50;
        }
        else
        {
            NGhostDirectorG.g = 0;
        }
        if (Input.GetKeyDown(KeyCode.H) && NGhostDirectorH.h == 0)
        {
            score -= 50;
        }
        else
        {
            NGhostDirectorH.h = 0;
        }
        if (Input.GetKeyDown(KeyCode.I) && NGhostDirectorI.i == 0)
        {
            score -= 50;
        }
        else
        {
            NGhostDirectorI.i = 0;
        }
        if (Input.GetKeyDown(KeyCode.J) && NGhostDirectorJ.j == 0)
        {
            score -= 50;
        }
        else
        {
            NGhostDirectorJ.j = 0;
        }
        if (Input.GetKeyDown(KeyCode.K) && NGhostDirectorK.k == 0)
        {
            score -= 50;
        }
        else
        {
            NGhostDirectorK.k = 0;
        }
        if (Input.GetKeyDown(KeyCode.L) && NGhostDirectorL.l == 0)
        {
            score -= 50;
        }
        else
        {
            NGhostDirectorL.l = 0;
        }
        if (Input.GetKeyDown(KeyCode.M) && NGhostDirectorM.m == 0)
        {
            score -= 50;
        }
        else
        {
            NGhostDirectorM.m = 0;
        }
        if (Input.GetKeyDown(KeyCode.N) && NGhostDirectorN.n == 0)
        {
            score -= 50;
        }
        else
        {
            NGhostDirectorN.n = 0;
        }
        if (Input.GetKeyDown(KeyCode.O) && NGhostDirectorO.o == 0)
        {
            score -= 50;
        }
        else
        {
            NGhostDirectorO.o = 0;
        }
        if (Input.GetKeyDown(KeyCode.P) && NGhostDirectorP.p == 0)
        {
            score -= 50;
        }
        else
        {
            NGhostDirectorP.p = 0;
        }
        if (Input.GetKeyDown(KeyCode.Q) && NGhostDirectorQ.q == 0)
        {
            score -= 50;
        }
        else
        {
            NGhostDirectorQ.q = 0;
        }
        if (Input.GetKeyDown(KeyCode.R) && NGhostDirectorR.r == 0)
        {
            score -= 50;
        }
        else
        {
            NGhostDirectorR.r = 0;
        }
        if (Input.GetKeyDown(KeyCode.S) && NGhostDirectorS.s == 0)
        {
            score -= 50;
        }
        else
        {
            NGhostDirectorS.s = 0;
        }
        if (Input.GetKeyDown(KeyCode.T) && NGhostDirectorT.t == 0)
        {
            score -= 50;
        }
        else
        {
            NGhostDirectorT.t = 0;
        }
        if (Input.GetKeyDown(KeyCode.U) && NGhostDirectorU.u == 0)
        {
            score -= 50;
        }
        else
        {
            NGhostDirectorU.u = 0;
        }
        if (Input.GetKeyDown(KeyCode.V) && NGhostDirectorV.v == 0)
        {
            score -= 50;
        }
        else
        {
            NGhostDirectorV.v = 0;
        }
        if (Input.GetKeyDown(KeyCode.W) && NGhostDirectorW.w == 0)
        {
            score -= 50;
        }
        else
        {
            NGhostDirectorW.w = 0;
        }
        if (Input.GetKeyDown(KeyCode.X) && NGhostDirectorX.x == 0)
        {
            score -= 50;
        }
        else
        {
            NGhostDirectorX.x = 0;
        }
        if (Input.GetKeyDown(KeyCode.Y) && NGhostDirectorY.y == 0)
        {
            score -= 50;
        }
        else
        {
            NGhostDirectorY.y = 0;
        }
        if (Input.GetKeyDown(KeyCode.Z) && NGhostDirectorZ.z == 0)
        {
            score -= 50;
        }
        else
        {
            NGhostDirectorZ.z = 0;
        }
    }
}

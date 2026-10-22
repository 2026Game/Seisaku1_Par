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

       
            if (GhostDirector.missA == 1 && GhostDirector.Aobake == 0 )
            {
                GhostDirector.missA = 0;
                GhostDirector.Aobake = 1;
                if (GhostDirector.missA == 0)
                {
                    GhostDirector.missA = 1;
                }

            }
            else if (NGhostDirectorB.missB == 1 && NGhostDirectorB.Bobake == 0 )
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
        else if (NGhostDirectorE.missE == 1 && NGhostDirectorE.Eobake == 0)
        {
            NGhostDirectorE.missE = 0;
            NGhostDirectorE.Eobake = 1;
            if (NGhostDirectorE.missE == 0)
            {
                NGhostDirectorE.missE = 1;
            }
        }
        else if (NGhostDirectorF.missF == 1 && NGhostDirectorF.Fobake == 0)
        {
            NGhostDirectorF.missF = 0;
            NGhostDirectorF.Fobake = 1;
            if (NGhostDirectorF.missF == 0)
            {
                NGhostDirectorF.missF = 1;
            }
        }
        else if (NGhostDirectorG.missG == 1 && NGhostDirectorG.Gobake == 0)
        {
            NGhostDirectorG.missG = 0;
            NGhostDirectorG.Gobake = 1;
            if (NGhostDirectorG.missG == 0)
            {
                NGhostDirectorG.missG = 1;
            }
        }
        else if (NGhostDirectorH.missH == 1 && NGhostDirectorH.Hobake == 0)
        {
            NGhostDirectorH.missH = 0;
            NGhostDirectorH.Hobake = 1;
            if (NGhostDirectorH.missH == 0)
            {
                NGhostDirectorH.missH = 1;
            }
        }
        else if (NGhostDirectorI.missI == 1 && NGhostDirectorI.Iobake == 0)
        {
            NGhostDirectorI.missI = 0;
            NGhostDirectorI.Iobake = 1;
            if (NGhostDirectorI.missI == 0)
            {
                NGhostDirectorI.missI = 1;
            }
        }
        else if (NGhostDirectorJ.missJ == 1 && NGhostDirectorJ.Jobake == 0)
        {
            NGhostDirectorJ.missJ = 0;
            NGhostDirectorJ.Jobake = 1;
            if (NGhostDirectorJ.missJ == 0)
            {
                NGhostDirectorJ.missJ = 1;
            }
        }
        else if (NGhostDirectorK.missK == 1 && NGhostDirectorK.Kobake == 0)
        {
            NGhostDirectorK.missK = 0;
            NGhostDirectorK.Kobake = 1;
            if (NGhostDirectorK.missK == 0)
            {
                NGhostDirectorK.missK = 1;
            }
        }
        else if (NGhostDirectorL.missL == 1 && NGhostDirectorL.Lobake == 0)
        {
            NGhostDirectorL.missL = 0;
            NGhostDirectorL.Lobake = 1;
            if (NGhostDirectorL.missL == 0)
            {
                NGhostDirectorL.missL = 1;
            }
        }
        else if (NGhostDirectorM.missM == 1 && NGhostDirectorM.Mobake == 0)
        {
            NGhostDirectorM.missM = 0;
            NGhostDirectorM.Mobake = 1;
            if (NGhostDirectorM.missM == 0)
            {
                NGhostDirectorM.missM = 1;
            }
        }
        else if (NGhostDirectorN.missN == 1 && NGhostDirectorN.Nobake == 0)
        {
            NGhostDirectorN.missN = 0;
            NGhostDirectorN.Nobake = 1;
            if (NGhostDirectorN.missN == 0)
            {
                NGhostDirectorN.missN = 1;
            }
        }
        else if (NGhostDirectorO.missO == 1 && NGhostDirectorO.Oobake == 0)
        {
            NGhostDirectorO.missO = 0;
            NGhostDirectorO.Oobake = 1;
            if (NGhostDirectorO.missO == 0)
            {
                NGhostDirectorO.missO = 1;
            }
        }
        else if (NGhostDirectorP.missP == 1 && NGhostDirectorP.Pobake == 0)
        {
            NGhostDirectorP.missP = 0;
            NGhostDirectorP.Pobake = 1;
            if (NGhostDirectorP.missP == 0)
            {
                NGhostDirectorP.missP = 1;
            }
        }
        else if (NGhostDirectorQ.missQ == 1 && NGhostDirectorQ.Qobake == 0)
        {
            NGhostDirectorQ.missQ = 0;
            NGhostDirectorQ.Qobake = 1;
            if (NGhostDirectorQ.missQ == 0)
            {
                NGhostDirectorQ.missQ = 1;
            }
        }
        else if (NGhostDirectorR.missR == 1 && NGhostDirectorR.Robake == 0)
        {
            NGhostDirectorR.missR = 0;
            NGhostDirectorR.Robake = 1;
            if (NGhostDirectorR.missR == 0)
            {
                NGhostDirectorR.missR = 1;
            }
        }
        else if (NGhostDirectorS.missS == 1 && NGhostDirectorS.Sobake == 0)
        {
            NGhostDirectorS.missS = 0;
            NGhostDirectorS.Sobake = 1;
            if (NGhostDirectorS.missS == 0)
            {
                NGhostDirectorS.missS = 1;
            }
        }
        else if (NGhostDirectorT.missT == 1 && NGhostDirectorT.Tobake == 0)
        {
            NGhostDirectorT.missT = 0;
            NGhostDirectorT.Tobake = 1;
            if (NGhostDirectorT.missT == 0)
            {
                NGhostDirectorT.missT = 1;
            }
        }
        else if (NGhostDirectorU.missU == 1 && NGhostDirectorU.Uobake == 0)
        {
            NGhostDirectorU.missU = 0;
            NGhostDirectorU.Uobake = 1;
            if (NGhostDirectorU.missU == 0)
            {
                NGhostDirectorU.missU = 1;
            }
        }
        else if (NGhostDirectorV.missV == 1 && NGhostDirectorV.Vobake == 0)
        {
            NGhostDirectorV.missV = 0;
            NGhostDirectorV.Vobake = 1;
            if (NGhostDirectorV.missV == 0)
            {
                NGhostDirectorV.missV = 1;
            }
        }
        else if (NGhostDirectorW.missW == 1 && NGhostDirectorW.Wobake == 0)
        {
            NGhostDirectorW.missW = 0;
            NGhostDirectorW.Wobake = 1;
            if (NGhostDirectorW.missW == 0)
            {
                NGhostDirectorW.missW = 1;
            }
        }
        else if (NGhostDirectorX.missX == 1 && NGhostDirectorX.Xobake == 0)
        {
            NGhostDirectorX.missX = 0;
            NGhostDirectorX.Xobake = 1;
            if (NGhostDirectorX.missX == 0)
            {
                NGhostDirectorX.missX = 1;
            }
        }
        else if (NGhostDirectorY.missY == 1 && NGhostDirectorY.Yobake == 0)
        {
            NGhostDirectorY.missY = 0;
            NGhostDirectorY.Yobake = 1;
            if (NGhostDirectorY.missY == 0)
            {
                NGhostDirectorY.missY = 1;
            }
        }
        else if (NGhostDirectorZ.missZ == 1 && NGhostDirectorZ.Zobake == 0)
        {
            NGhostDirectorZ.missZ = 0;
            NGhostDirectorZ.Zobake = 1;
            if (NGhostDirectorZ.missZ == 0)
            {
                NGhostDirectorZ.missZ = 1;
            }
        }
    }
}

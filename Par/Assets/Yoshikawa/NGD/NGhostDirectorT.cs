using UnityEngine;

public class NGhostDirectorT : MonoBehaviour
{
    public static int Tobake = 1;
    public static int t = 1;
    int Trenda = 0;
    float NGTtime = 5;
    public static int NGTretime = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        t = 1;
        NGTtime -= Time.deltaTime;
        NGTretime = (int)NGTtime;
        if (Input.GetKeyDown(KeyCode.T))
        {
            Trenda += 1;
            if (Trenda == 5)
            {
                GameDirector.score += 100;
                Destroy(this.gameObject);
                NGTGenerator.T = 0;
            }
        }
       

        if (NGTretime == 0)
        {
            Destroy(gameObject);
            HPDirector.HP -= 1;
            NGTtime = 5;
            NGTGenerator.T = 0;
            t = 0;
        }

        if (GameDirector.hour == 6)
        {
            Destroy(this.gameObject);
        }

    }
}

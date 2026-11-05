using UnityEngine;

public class NGhostDirectorS : MonoBehaviour
{
    public static int Sobake = 1;
    public static int s = 1;
    int Srenda = 0;
    float NGStime = 5;
    public static int NGSretime = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        s = 1;
        NGStime -= Time.deltaTime;
        NGSretime = (int)NGStime;
        if (Input.GetKeyDown(KeyCode.S))
        {
            Srenda += 1;
            if (Srenda == 5)
            {
                GameDirector.score += 100;
                Destroy(this.gameObject);
                NGSGenerator.S = 0;
               
            }
        }
        

        if (NGSretime == 0)
        {
            Destroy(gameObject);
            HPDirector.HP -= 1;
            NGStime = 5;
            NGSGenerator.S = 0;
            s = 0;
        }

        if (GameDirector.hour == 6)
        {
            Destroy(this.gameObject);
        }

    }
}

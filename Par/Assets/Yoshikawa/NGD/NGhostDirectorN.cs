using UnityEngine;

public class NGhostDirectorN : MonoBehaviour
{
    public static int Nobake = 1;
    public static int n = 1;
    float NGNtime = 5;
    public static int NGNretime = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        n = 1;
        NGNtime -= Time.deltaTime;
        NGNretime = (int)NGNtime;
        if (Input.GetKeyDown(KeyCode.N))
        {
            GameDirector.score += 100;
            Destroy(this.gameObject);
            NGNGenerator.N = 0;
           
        }
       

        if (NGNretime == 0)
        {
            Destroy(gameObject);
            HPDirector.HP -= 1;
            NGNtime = 5;
            NGNGenerator.N = 0;
            n = 0;
        }

        if (GameDirector.hour == 6)
        {
            Destroy(this.gameObject);
        }

    }
}

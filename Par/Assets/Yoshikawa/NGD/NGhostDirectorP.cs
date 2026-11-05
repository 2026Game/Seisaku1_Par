using UnityEngine;

public class NGhostDirectorP : MonoBehaviour
{
    public static int Pobake = 1;
    public static int p = 1;
    int Prenda = 0;
    float NGPtime = 5;
    public static int NGPretime = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        p = 1;
        NGPtime -= Time.deltaTime;
        NGPretime = (int)NGPtime;
        if (Input.GetKeyDown(KeyCode.P))
        {
            Prenda+=1;
            if (Prenda == 5)
            {
                GameDirector.score += 100;
                Destroy(this.gameObject);
                NGPGenerator.P = 0;
                Prenda = 0;
            }
           
        }
        

        if (NGPretime == 0)
        {
            Destroy(gameObject);
            HPDirector.HP -= 1;
            NGPtime = 5;
            NGPGenerator.P = 0;
            p = 0;
        }

        if (GameDirector.hour == 6)
        {
            Destroy(this.gameObject);
        }

    }
}

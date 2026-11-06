using UnityEngine;

public class NGhostDirectorE : MonoBehaviour
{
    public static int Eobake = 1;
    public static int e = 1;
    float NGEtime = 5;
    public static int NGEretime = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        e = 1;
        NGEtime -= Time.deltaTime;
        NGEretime = (int)NGEtime;
        if (Input.GetKeyDown(KeyCode.E))
        {
            GameDirector.score += 100;
            Destroy(this.gameObject);
            NGEGenerator.E = 0;
            
        }
        

        if (NGEretime == 0)
        {
            Destroy(gameObject);
            HPDirector.HP -= 1;
            NGEtime = 5;
            NGEGenerator.E = 0;
            e = 0;
        }

        if (GameDirector.hour == 6)
        {
            Destroy(this.gameObject);
        }

    }
}

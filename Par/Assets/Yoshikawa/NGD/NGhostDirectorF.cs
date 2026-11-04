using UnityEngine;

public class NGhostDirectorF : MonoBehaviour
{
    public static int Fobake = 1;
    public static int f = 1;
    float NGFtime = 5;
    public static int NGFretime = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        f = 1;
        NGFtime -= Time.deltaTime;
        NGFretime = (int)NGFtime;
        if (Input.GetKeyDown(KeyCode.F))
        {
            GameDirector.score += 100;
            Destroy(this.gameObject);
            NGFGenerator.F = 0;
           
        }
        

        if (NGFretime == 0)
        {
            Destroy(gameObject);
            HPDirector.HP -= 1;
            NGFtime = 5;
            NGFGenerator.F = 0;
            f = 0;
        }

        if (GameDirector.hour == 6)
        {
            Destroy(this.gameObject);
        }

    }
}

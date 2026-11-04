using UnityEngine;

public class NGhostDirectorO : MonoBehaviour
{
    public static int Oobake = 1;
    public static int o = 1;
    float NGOtime = 5;
    public static int NGOretime = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        o = 1;
        NGOtime -= Time.deltaTime;
        NGOretime = (int)NGOtime;
        if (Input.GetKeyDown(KeyCode.O))
        {
            GameDirector.score += 100;
            Destroy(this.gameObject);
            NGOGenerator.O = 0;
           
        }
        

        if (NGOretime == 0)
        {
            Destroy(gameObject);
            HPDirector.HP -= 1;
            NGOtime = 5;
            NGOGenerator.O = 0;
            o = 0;
        }

        if (GameDirector.hour == 6)
        {
            Destroy(this.gameObject);
        }

    }
}

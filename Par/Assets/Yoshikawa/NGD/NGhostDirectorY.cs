using UnityEngine;

public class NGhostDirectorY : MonoBehaviour
{
    public static int Yobake = 1;
    public static int y = 1;
    float NGYtime = 5;
    public static int NGYretime = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        y = 1;
        NGYtime -= Time.deltaTime;
        NGYretime = (int)NGYtime;
        if (Input.GetKeyDown(KeyCode.Y))
        {
            GameDirector.score += 300;
            Destroy(this.gameObject);
            NGYGenerator.Y = 0;
            
        }
        

        if (NGYretime == 0)
        {
            Destroy(gameObject);
            HPDirector.HP -= 1;
            NGYtime = 5;
            NGYGenerator.Y = 0;
            y = 0;
        }

        if (GameDirector.hour == 6)
        {
            Destroy(this.gameObject);
        }

    }
}

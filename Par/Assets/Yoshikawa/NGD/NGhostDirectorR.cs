using UnityEngine;

public class NGhostDirectorR : MonoBehaviour
{
    public static int Robake = 1;
    public static int missR = 1;
    float NGRtime = 5;
    public static int NGRretime = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        NGRtime -= Time.deltaTime;
        NGRretime = (int)NGRtime;
        if (Input.GetKeyDown(KeyCode.R))
        {
            GameDirector.score += 100;
            Destroy(this.gameObject);
            NGRGenerator.R = 0;
            missR = 1;
        }
        else if (Input.anyKeyDown && !Input.GetKeyDown(KeyCode.R))
        {
            Robake = 0;
        }

        if (NGRretime == 0)
        {
            Destroy(gameObject);
            HPDirector.HP -= 1;
            NGRtime = 5;
            NGRGenerator.R = 0;
        }

        if (GameDirector.hour == 6)
        {
            Destroy(this.gameObject);
        }

    }
}

using UnityEngine;

public class NGhostDirectorY : MonoBehaviour
{
    public static int Yobake = 1;
    public static int missY = 1;
    float NGYtime = 5;
    public static int NGYretime = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        NGYtime -= Time.deltaTime;
        NGYretime = (int)NGYtime;
        if (Input.GetKeyDown(KeyCode.Y))
        {
            GameDirector.score += 100;
            Destroy(this.gameObject);
            NGYGenerator.Y = 0;
            missY = 1;
        }
        else if (Input.anyKeyDown && !Input.GetKeyDown(KeyCode.Y))
        {
            Yobake = 0;
        }

        if (NGYretime == 0)
        {
            Destroy(gameObject);
            HPDirector.HP -= 1;
            NGYtime = 5;
            NGYGenerator.Y = 0;
        }

        if (GameDirector.hour == 6)
        {
            Destroy(this.gameObject);
        }

    }
}

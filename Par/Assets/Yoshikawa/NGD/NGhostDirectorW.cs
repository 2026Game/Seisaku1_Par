using UnityEngine;

public class NGhostDirectorW : MonoBehaviour
{
    public static int Wobake = 1;
    public static int missW = 1;
    float NGWtime = 5;
    public static int NGWretime = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        NGWtime -= Time.deltaTime;
        NGWretime = (int)NGWtime;
        if (Input.GetKeyDown(KeyCode.W))
        {
            GameDirector.score += 100;
            Destroy(this.gameObject);
            NGWGenerator.W = 0;
            missW = 1;
        }
        else if (Input.anyKeyDown && !Input.GetKeyDown(KeyCode.W))
        {
            Wobake = 0;
        }

        if (NGWretime == 0)
        {
            Destroy(gameObject);
            HPDirector.HP -= 1;
            NGWtime = 5;
            NGWGenerator.W = 0;
        }

        if (GameDirector.hour == 6)
        {
            Destroy(this.gameObject);
        }

    }
}

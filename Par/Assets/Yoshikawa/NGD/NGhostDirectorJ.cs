using UnityEngine;

public class NGhostDirectorJ : MonoBehaviour
{
    public static int Jobake = 1;
    public static int missJ = 1;
    float NGJtime = 5;
    int NGJretime = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        NGJtime -= Time.deltaTime;
        NGJretime = (int)NGJtime;
        if (Input.GetKeyDown(KeyCode.J))
        {
            GameDirector.score += 100;
            Destroy(this.gameObject);
            NGJGenerator.J = 0;
            missJ = 1;
        }
        else if (Input.anyKeyDown && !Input.GetKeyDown(KeyCode.J))
        {
            Jobake = 0;
        }

        if (NGJretime == 0)
        {
            Destroy(gameObject);
            HPDirector.HP -= 1;
            NGJtime = 5;
            NGJGenerator.J = 0;
        }

        if (GameDirector.hour == 6)
        {
            Destroy(this.gameObject);
        }

    }
}

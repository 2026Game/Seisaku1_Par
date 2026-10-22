using UnityEngine;

public class NGhostDirectorN : MonoBehaviour
{
    public static int Nobake = 1;
    public static int missN = 1;
    float NGNtime = 5;
    int NGNretime = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        NGNtime -= Time.deltaTime;
        NGNretime = (int)NGNtime;
        if (Input.GetKeyDown(KeyCode.N))
        {
            GameDirector.score += 100;
            Destroy(this.gameObject);
            NGNGenerator.N = 0;
            missN = 1;
        }
        else if (Input.anyKeyDown && !Input.GetKeyDown(KeyCode.N))
        {
            Nobake = 0;
        }

        if (NGNretime == 0)
        {
            Destroy(gameObject);
            HPDirector.HP -= 1;
            NGNtime = 5;
            NGNGenerator.N = 0;
        }

        if (GameDirector.hour == 6)
        {
            Destroy(this.gameObject);
        }

    }
}

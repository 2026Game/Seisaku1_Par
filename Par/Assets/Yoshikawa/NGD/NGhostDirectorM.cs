using UnityEngine;

public class NGhostDirectorM : MonoBehaviour
{
    public static int Mobake = 1;
    public static int missM = 1;
    float NGMtime = 5;
    int NGMretime = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        NGMtime -= Time.deltaTime;
        NGMretime = (int)NGMtime;
        if (Input.GetKeyDown(KeyCode.M))
        {
            GameDirector.score += 100;
            Destroy(this.gameObject);
            NGMGenerator.M = 0;
            missM = 1;
        }
        else if (Input.anyKeyDown && !Input.GetKeyDown(KeyCode.M))
        {
            Mobake = 0;
        }

        if (NGMretime == 0)
        {
            Destroy(gameObject);
            HPDirector.HP -= 1;
            NGMtime = 5;
            NGMGenerator.M = 0;
        }

    }
}

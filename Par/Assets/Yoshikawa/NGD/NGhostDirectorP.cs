using UnityEngine;

public class NGhostDirectorP : MonoBehaviour
{
    public static int Pobake = 1;
    public static int missP = 1;
    float NGPtime = 5;
    int NGPretime = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        NGPtime -= Time.deltaTime;
        NGPretime = (int)NGPtime;
        if (Input.GetKeyDown(KeyCode.P))
        {
            GameDirector.score += 100;
            Destroy(this.gameObject);
            NGPGenerator.P = 0;
            missP = 1;
        }
        else if (Input.anyKeyDown && !Input.GetKeyDown(KeyCode.P))
        {
            Pobake = 0;
        }

        if (NGPretime == 0)
        {
            Destroy(gameObject);
            HPDirector.HP -= 1;
            NGPtime = 5;
            NGPGenerator.P = 0;
        }

    }
}

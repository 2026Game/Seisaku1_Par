using UnityEngine;

public class NGhostDirectorS : MonoBehaviour
{
    public static int Sobake = 1;
    public static int missS = 1;
    float NGStime = 5;
    int NGSretime = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        NGStime -= Time.deltaTime;
        NGSretime = (int)NGStime;
        if (Input.GetKeyDown(KeyCode.S))
        {
            GameDirector.score += 100;
            Destroy(this.gameObject);
            NGSGenerator.S = 0;
            missS = 1;
        }
        else if (Input.anyKeyDown && !Input.GetKeyDown(KeyCode.S))
        {
            Sobake = 0;
        }

        if (NGSretime == 0)
        {
            Destroy(gameObject);
            HPDirector.HP -= 1;
            NGStime = 5;
            NGSGenerator.S = 0;
        }

    }
}

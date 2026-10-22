using UnityEngine;

public class NGhostDirectorQ : MonoBehaviour
{
    public static int Qobake = 1;
    public static int missQ = 1;
    float NGQtime = 5;
    int NGQretime = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        NGQtime -= Time.deltaTime;
        NGQretime = (int)NGQtime;
        if (Input.GetKeyDown(KeyCode.Q))
        {
            GameDirector.score += 100;
            Destroy(this.gameObject);
            NGQGenerator.Q = 0;
            missQ = 1;
        }
        else if (Input.anyKeyDown && !Input.GetKeyDown(KeyCode.Q))
        {
            Qobake = 0;
        }

        if (NGQretime == 0)
        {
            Destroy(gameObject);
            HPDirector.HP -= 1;
            NGQtime = 5;
            NGQGenerator.Q = 0;
        }

    }
}

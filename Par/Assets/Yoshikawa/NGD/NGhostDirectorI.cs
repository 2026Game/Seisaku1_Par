using UnityEngine;

public class NGhostDirectorI : MonoBehaviour
{
    public static int Iobake = 1;
    public static int missI = 1;
    float NGItime = 5;
    public static int NGIretime = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        NGItime -= Time.deltaTime;
        NGIretime = (int)NGItime;
        if (Input.GetKeyDown(KeyCode.I))
        {
            GameDirector.score += 100;
            Destroy(this.gameObject);
            NGIGenerator.I = 0;
            missI = 1;
        }
        else if (Input.anyKeyDown && !Input.GetKeyDown(KeyCode.I))
        {
            Iobake = 0;
        }

        if (NGIretime == 0)
        {
            Destroy(gameObject);
            HPDirector.HP -= 1;
            NGItime = 5;
            NGIGenerator.I = 0;
        }

        if (GameDirector.hour == 6)
        {
            Destroy(this.gameObject);
        }

    }
}

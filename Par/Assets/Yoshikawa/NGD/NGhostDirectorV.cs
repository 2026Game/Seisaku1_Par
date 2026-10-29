using UnityEngine;

public class NGhostDirectorV : MonoBehaviour
{
    public static int Vobake = 1;
    public static int missV = 1;
    float NGVtime = 5;
    public static int NGVretime = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        NGVtime -= Time.deltaTime;
        NGVretime = (int)NGVtime;
        if (Input.GetKeyDown(KeyCode.V))
        {
            GameDirector.score += 100;
            Destroy(this.gameObject);
            NGVGenerator.V = 0;
            missV = 1;
        }
        else if (Input.anyKeyDown && !Input.GetKeyDown(KeyCode.V))
        {
            Vobake = 0;
        }

        if (NGVretime == 0)
        {
            Destroy(gameObject);
            HPDirector.HP -= 1;
            NGVtime = 5;
            NGVGenerator.V = 0;
        }

        if (GameDirector.hour == 6)
        {
            Destroy(this.gameObject);
        }

    }
}

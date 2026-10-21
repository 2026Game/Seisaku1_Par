using UnityEngine;

public class NGhostDirectorD : MonoBehaviour
{
    public static int Dobake = 1;
    public static int missD = 1;
    float NGDtime = 5;
    int NGDretime = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        NGDtime -= Time.deltaTime;
        NGDretime = (int)NGDtime;
        if (Input.GetKeyDown(KeyCode.D))
        {
            GameDirector.score += 100;
            Destroy(this.gameObject);
            NGDGenerator.D = 0;
            missD = 1;
        }
        else if (Input.anyKeyDown && !Input.GetKeyDown(KeyCode.D))
        {
            Dobake = 0;
        }

        if (NGDretime == 0)
        {
            Destroy(gameObject);
            HPDirector.HP -= 1;
            NGDtime = 5;
            NGDGenerator.D = 0;
        }

    }
}

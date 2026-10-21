using UnityEngine;

public class NGhostDirectorG : MonoBehaviour
{
    public static int Gobake = 1;
    public static int missG = 1;
    float NGGtime = 5;
    int NGGretime = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        NGGtime -= Time.deltaTime;
        NGGretime = (int)NGGtime;
        if (Input.GetKeyDown(KeyCode.G))
        {
            GameDirector.score += 100;
            Destroy(this.gameObject);
            NGGGenerator.G = 0;
            missG = 1;
        }
        else if (Input.anyKeyDown && !Input.GetKeyDown(KeyCode.G))
        {
            Gobake = 0;
        }

        if (NGGretime == 0)
        {
            Destroy(gameObject);
            HPDirector.HP -= 1;
            NGGtime = 5;
            NGGGenerator.G = 0;
        }

    }
}

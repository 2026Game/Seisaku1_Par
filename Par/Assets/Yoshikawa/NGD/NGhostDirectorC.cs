using UnityEngine;

public class NGhostDirectorC : MonoBehaviour
{
    public static int Cobake = 1;
    public static int missC = 1;
    float NGCtime = 5;
    int NGCretime = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        NGCtime -= Time.deltaTime;
        NGCretime = (int)NGCtime;
        if (Input.GetKeyDown(KeyCode.C))
        {
            GameDirector.score += 100;
            Destroy(this.gameObject);
            NGCGenerator.C = 0;
            missC = 1;
        }
        else if (Input.anyKeyDown && !Input.GetKeyDown(KeyCode.C))
        {
            Cobake = 0;
        }

        if (NGCretime == 0)
        {
            Destroy(gameObject);
            HPDirector.HP -= 1;
            NGCtime = 5;
            NGCGenerator.C = 0;
        }

        if (GameDirector.hour == 6)
        {
            Destroy(this.gameObject);
        }

    }
}

using UnityEngine;

public class NGhostDirectorE : MonoBehaviour
{
    public static int Eobake = 1;
    public static int missE = 1;
    float NGEtime = 5;
    int NGEretime = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        NGEtime -= Time.deltaTime;
        NGEretime = (int)NGEtime;
        if (Input.GetKeyDown(KeyCode.E))
        {
            GameDirector.score += 100;
            Destroy(this.gameObject);
            NGEGenerator.E = 0;
            missE = 1;
        }
        else if (Input.anyKeyDown && !Input.GetKeyDown(KeyCode.E))
        {
            Eobake = 0;
        }

        if (NGEretime == 0)
        {
            Destroy(gameObject);
            HPDirector.HP -= 1;
            NGEtime = 5;
            NGEGenerator.E = 0;
        }

    }
}

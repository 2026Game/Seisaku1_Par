using UnityEngine;

public class NGhostDirectorF : MonoBehaviour
{
    public static int Fobake = 1;
    public static int missF = 1;
    float NGFtime = 5;
    int NGFretime = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        NGFtime -= Time.deltaTime;
        NGFretime = (int)NGFtime;
        if (Input.GetKeyDown(KeyCode.F))
        {
            GameDirector.score += 100;
            Destroy(this.gameObject);
            NGFGenerator.F = 0;
            missF = 1;
        }
        else if (Input.anyKeyDown && !Input.GetKeyDown(KeyCode.F))
        {
            Fobake = 0;
        }

        if (NGFretime == 0)
        {
            Destroy(gameObject);
            HPDirector.HP -= 1;
            NGFtime = 5;
            NGFGenerator.F = 0;
        }

    }
}

using UnityEngine;

public class NGhostDirectorU : MonoBehaviour
{
    public static int Uobake = 1;
    public static int missU = 1;
    float NGUtime = 5;
    int NGUretime = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        NGUtime -= Time.deltaTime;
        NGUretime = (int)NGUtime;
        if (Input.GetKeyDown(KeyCode.U))
        {
            GameDirector.score += 100;
            Destroy(this.gameObject);
            NGUGenerator.U = 0;
            missU = 1;
        }
        else if (Input.anyKeyDown && !Input.GetKeyDown(KeyCode.U))
        {
            Uobake = 0;
        }

        if (NGUretime == 0)
        {
            Destroy(gameObject);
            HPDirector.HP -= 1;
            NGUtime = 5;
            NGUGenerator.U = 0;
        }

        if (GameDirector.hour == 6)
        {
            Destroy(this.gameObject);
        }

    }
}

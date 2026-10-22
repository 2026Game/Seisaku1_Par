using UnityEngine;

public class NGhostDirectorL : MonoBehaviour
{
    public static int Lobake = 1;
    public static int missL = 1;
    float NGLtime = 5;
    int NGLretime = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        NGLtime -= Time.deltaTime;
        NGLretime = (int)NGLtime;
        if (Input.GetKeyDown(KeyCode.L))
        {
            GameDirector.score += 100;
            Destroy(this.gameObject);
            NGLGenerator.L = 0;
            missL = 1;
        }
        else if (Input.anyKeyDown && !Input.GetKeyDown(KeyCode.L))
        {
            Lobake = 0;
        }

        if (NGLretime == 0)
        {
            Destroy(gameObject);
            HPDirector.HP -= 1;
            NGLtime = 5;
            NGLGenerator.L = 0;
        }

    }
}

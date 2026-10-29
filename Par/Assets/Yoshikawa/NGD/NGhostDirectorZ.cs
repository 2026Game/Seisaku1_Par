using UnityEngine;

public class NGhostDirectorZ : MonoBehaviour
{
    public static int Zobake = 1;
    public static int missZ = 1;
    float NGZtime = 5;
    public static int NGZretime = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        NGZtime -= Time.deltaTime;
        NGZretime = (int)NGZtime;
        if (Input.GetKeyDown(KeyCode.Z))
        {
            GameDirector.score += 100;
            Destroy(this.gameObject);
            NGZGenerator.Z = 0;
            missZ = 1;
        }
        else if (Input.anyKeyDown && !Input.GetKeyDown(KeyCode.Z))
        {
            Zobake = 0;
        }

        if (NGZretime == 0)
        {
            Destroy(gameObject);
            HPDirector.HP -= 1;
            NGZtime = 5;
            NGZGenerator.Z = 0;
        }

        if (GameDirector.hour == 6)
        {
            Destroy(this.gameObject);
        }

    }
}

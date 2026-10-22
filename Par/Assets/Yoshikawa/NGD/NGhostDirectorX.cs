using UnityEngine;

public class NGhostDirectorX : MonoBehaviour
{
    public static int Xobake = 1;
    public static int missX = 1;
    float NGXtime = 5;
    int NGXretime = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        NGXtime -= Time.deltaTime;
        NGXretime = (int)NGXtime;
        if (Input.GetKeyDown(KeyCode.X))
        {
            GameDirector.score += 100;
            Destroy(this.gameObject);
            NGXGenerator.X = 0;
            missX = 1;
        }
        else if (Input.anyKeyDown && !Input.GetKeyDown(KeyCode.X))
        {
            Xobake = 0;
        }

        if (NGXretime == 0)
        {
            Destroy(gameObject);
            HPDirector.HP -= 1;
            NGXtime = 5;
            NGXGenerator.X = 0;
        }

        if (GameDirector.hour == 6)
        {
            Destroy(this.gameObject);
        }

    }
}

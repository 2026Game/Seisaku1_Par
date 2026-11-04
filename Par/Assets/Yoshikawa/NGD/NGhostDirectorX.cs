using UnityEngine;

public class NGhostDirectorX : MonoBehaviour
{
    public static int Xobake = 1;
    public static int x = 1;
    float NGXtime = 5;
    public static int NGXretime = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        x = 1;
        NGXtime -= Time.deltaTime;
        NGXretime = (int)NGXtime;
        if (Input.GetKeyDown(KeyCode.X))
        {
            GameDirector.score += 300;
            Destroy(this.gameObject);
            NGXGenerator.X = 0;
            
        }
        

        if (NGXretime == 0)
        {
            Destroy(gameObject);
            HPDirector.HP -= 1;
            NGXtime = 5;
            NGXGenerator.X = 0;
            x = 0;
        }

        if (GameDirector.hour == 6)
        {
            Destroy(this.gameObject);
        }

    }
}

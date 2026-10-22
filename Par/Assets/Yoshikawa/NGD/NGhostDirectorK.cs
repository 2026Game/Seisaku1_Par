using UnityEngine;

public class NGhostDirectorK : MonoBehaviour
{
    public static int Kobake = 1;
    public static int missK = 1;
    float NGKtime = 5;
    int NGKretime = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        NGKtime -= Time.deltaTime;
        NGKretime = (int)NGKtime;
        if (Input.GetKeyDown(KeyCode.K))
        {
            GameDirector.score += 100;
            Destroy(this.gameObject);
            NGKGenerator.K = 0;
            missK = 1;
        }
        else if (Input.anyKeyDown && !Input.GetKeyDown(KeyCode.K))
        {
            Kobake = 0;
        }

        if (NGKretime == 0)
        {
            Destroy(gameObject);
            HPDirector.HP -= 1;
            NGKtime = 5;
            NGKGenerator.K = 0;
        }

    }
}

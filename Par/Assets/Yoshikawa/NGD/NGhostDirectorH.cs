using UnityEngine;

public class NGhostDirectorH : MonoBehaviour
{
    public static int Hobake = 1;
    public static int missH = 1;
    float NGHtime = 5;
    int NGHretime = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        NGHtime -= Time.deltaTime;
        NGHretime = (int)NGHtime;
        if (Input.GetKeyDown(KeyCode.H))
        {
            GameDirector.score += 100;
            Destroy(this.gameObject);
            NGHGenerator.H = 0;
            missH = 1;
        }
        else if (Input.anyKeyDown && !Input.GetKeyDown(KeyCode.H))
        {
            Hobake = 0;
        }

        if (NGHretime == 0)
        {
            Destroy(gameObject);
            HPDirector.HP -= 1;
            NGHtime = 5;
            NGHGenerator.H = 0;
        }

    }
}

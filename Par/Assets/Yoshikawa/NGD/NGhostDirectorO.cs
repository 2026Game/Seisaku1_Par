using UnityEngine;

public class NGhostDirectorO : MonoBehaviour
{
    public static int Oobake = 1;
    public static int missO = 1;
    float NGOtime = 5;
    int NGOretime = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        NGOtime -= Time.deltaTime;
        NGOretime = (int)NGOtime;
        if (Input.GetKeyDown(KeyCode.O))
        {
            GameDirector.score += 100;
            Destroy(this.gameObject);
            NGOGenerator.O = 0;
            missO = 1;
        }
        else if (Input.anyKeyDown && !Input.GetKeyDown(KeyCode.O))
        {
            Oobake = 0;
        }

        if (NGOretime == 0)
        {
            Destroy(gameObject);
            HPDirector.HP -= 1;
            NGOtime = 5;
            NGOGenerator.O = 0;
        }

    }
}

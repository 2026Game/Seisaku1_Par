using Unity.VisualScripting;
using UnityEngine;

public class NGhostDirectorB : MonoBehaviour
{
    public static int Bobake = 1;
    public static int missB = 0;
    float NGBtime = 5;
    int NGBretime = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        NGBtime -= Time.deltaTime;
        NGBretime = (int)NGBtime;
        if (Input.GetKeyDown(KeyCode.B))
        {
            GameDirector.score += 100;
            Destroy(this.gameObject);
            NGBGenerator.B = 0;
            missB = 1;
            
        }
        else
        {
            missB = 0;
        }
        if (Input.anyKeyDown && !Input.GetKeyDown(KeyCode.B))
        {
            if (GhostDirector.missA == 0 && missB == 0 && NGhostDirectorC.missC == 0)
            {
                GameDirector.score -= 50;
            }
        }

        if (NGBretime == 0)
        {
            Destroy(gameObject);
            HPDirector.HP -= 1;
            NGBtime = 5;
            NGBGenerator. B= 0;
        }

        if (GameDirector.hour == 6)
        {
            Destroy(this.gameObject);
        }

    }
}

using Unity.VisualScripting;
using UnityEngine;

public class NGhostDirectorB : MonoBehaviour
{
    public static int Bobake = 1;
    public static int missB = 1;
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
        else if (Input.anyKeyDown && !Input.GetKeyDown(KeyCode.B))
        {
            Bobake = 0;
            
        }

        if (NGBretime == 0)
        {
            Destroy(gameObject);
            HPDirector.HP -= 1;
            NGBtime = 5;
            NGBGenerator. B= 0;
        }

    }
}

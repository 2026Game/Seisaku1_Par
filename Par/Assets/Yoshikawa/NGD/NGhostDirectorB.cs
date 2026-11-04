using Unity.VisualScripting;
using UnityEngine;

public class NGhostDirectorB : MonoBehaviour
{
    public static int Bobake = 1;
    public static int b = 1;
    float NGBtime = 5;
    public static int NGBretime = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        b = 1;
        NGBtime -= Time.deltaTime;
        NGBretime = (int)NGBtime;
        if (Input.GetKeyDown(KeyCode.B))
        {
            GameDirector.score += 100;
            Destroy(this.gameObject);
            NGBGenerator.B = 0;
        }
        
       

        if (NGBretime == 0)
        {
            Destroy(gameObject);
            HPDirector.HP -= 1;
            NGBtime = 5;
            NGBGenerator. B= 0;
            b = 0;
        }

        if (GameDirector.hour == 6)
        {
            Destroy(this.gameObject);
        }

    }
}

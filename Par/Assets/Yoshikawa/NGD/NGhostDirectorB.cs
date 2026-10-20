using Unity.VisualScripting;
using UnityEngine;

public class NGhostDirectorB : MonoBehaviour
{
    public static int Bobake = 1;
    public static int missB = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.B))
        {
            GameDirector.score += 100;
            Destroy(this.gameObject);
            NGBGenerator.B = 0;
            GameDirector.miss = 0;
            missB = 1;
        }
        else if (Input.anyKeyDown && !Input.GetKeyDown(KeyCode.B))
        {
            Bobake = 0;
        }
    }
}

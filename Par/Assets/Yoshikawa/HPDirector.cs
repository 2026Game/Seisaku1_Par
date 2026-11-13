using UnityEngine;

public class HPDirector : MonoBehaviour
{
    public static int HP = 3;
    public GameObject pHP;
    public GameObject pHP2;
    public GameObject pHP3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(HP>=3)
        {
            GameObject PHP;
            PHP=Instantiate(pHP);
            PHP.transform.position = new Vector3(-700, -155, 0);
            
        }
        if (HP >= 2)
        {
            GameObject PHP2;
            PHP2 = Instantiate(pHP2);
            PHP2.transform.position = new Vector3(-764, -155, 0);
           
        }
        if (HP >= 1)
        {
            GameObject PHP3;
            PHP3 = Instantiate(pHP3);
            PHP3.transform.position = new Vector3(-830, -155, 0);
            
        }
        
    }
}

using UnityEngine;

public class HPDirector : MonoBehaviour
{
    public static int HP = 3;
    public static int sHP;
    public static int sHP2;
    public static int sHP3;
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
        if(HP>=3 && sHP==0)
        {
            GameObject PHP;
            PHP=Instantiate(pHP);
            PHP.transform.position = new Vector3(-700, -155, 0);
            sHP = 1;
            
        }
        if (HP >= 2 && sHP2==0)
        {
            GameObject PHP2;
            PHP2 = Instantiate(pHP2);
            PHP2.transform.position = new Vector3(-764, -155, 0);
            sHP2 = 1;
        }
        if (HP >= 1 && sHP3 == 0)
        {
            GameObject PHP3;
            PHP3 = Instantiate(pHP3);
            PHP3.transform.position = new Vector3(-830, -155, 0);
            sHP3 = 1;
        }
        
    }
}

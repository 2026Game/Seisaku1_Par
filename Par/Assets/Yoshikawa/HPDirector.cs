using UnityEngine;

public class HPDirector : MonoBehaviour
{
    public static int HP = 3;
    GameObject hp1;
    GameObject hp2;
    GameObject hp3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.hp1= GameObject.Find("HP1");
        this.hp2 = GameObject.Find("HP2");
        this.hp3 = GameObject.Find("HP3");
    }

    // Update is called once per frame
    void Update()
    {
        if(HP==2)
        {
            Destroy(this.hp3);
        }
        if (HP == 1)
        {
            Destroy(this.hp2);
        }
        if (HP == 0)
        {
            Destroy(this.hp1);
        }
    }
}

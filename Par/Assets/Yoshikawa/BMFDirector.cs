using UnityEngine;

public class BMFDirector : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameDirector.hour == 5 && GameDirector.minute < 6)
        {
            transform.position = new Vector3(-10, 255, 0);
        }
        else
        {
            transform.position = new Vector3(0, -1200, 0);
        }
    }
}

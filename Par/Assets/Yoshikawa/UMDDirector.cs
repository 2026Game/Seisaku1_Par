using UnityEngine;

public class UMDDirector : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameDirector.hour==2 && GameDirector.minute<3)
        {
            transform.position = new Vector3(700, 425, 0);
        }
        else
        {
            transform.position = new Vector3(1440, -300, 0);
        }
    }
}

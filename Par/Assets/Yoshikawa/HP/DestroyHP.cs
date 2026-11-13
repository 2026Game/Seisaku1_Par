using UnityEngine;

public class DestroyHP : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(HPDirector.HP==2)
        {
            Destroy(gameObject);
        }
    }
}

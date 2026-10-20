using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SocialPlatforms.Impl;

public class GhostDirector : MonoBehaviour
{
    public static int Aobake = 1;
    public static int missA = 1;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.A))
        {
            GameDirector.score += 100;
            Destroy(this.gameObject);
            NGAGenerator.A = 0;
            GameDirector.miss = 0;
            missA = 1;
        }
        else if (Input.anyKeyDown && !Input.GetKeyDown(KeyCode.A))
        {
            Aobake = 0;
        }

    }

}

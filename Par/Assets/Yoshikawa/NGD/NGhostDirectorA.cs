using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SocialPlatforms.Impl;

public class GhostDirector : MonoBehaviour
{
    public static int Aobake = 1;
    public static int missA = 1;
    float NGAtime = 5;
    int NGAretime = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        NGAtime -= Time.deltaTime;
        NGAretime = (int)NGAtime;
        if (Input.GetKeyDown(KeyCode.A))
        {
            GameDirector.score += 100;
            Destroy(this.gameObject);
            NGAGenerator.A = 0;
            missA = 1;
        }
        else if (Input.anyKeyDown && !Input.GetKeyDown(KeyCode.A))
        {
            Aobake = 0;
        }

        if(NGAretime==0)
        {
            Destroy(gameObject);
            HPDirector.HP -= 1;
            NGAtime = 5;
            NGAGenerator.A = 0;
        }

    }

}

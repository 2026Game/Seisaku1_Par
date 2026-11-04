using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SocialPlatforms.Impl;

public class GhostDirector : MonoBehaviour
{
    public static int Aobake = 1;
    public static int a = 1;
    float NGAtime = 5;
    public static int NGAretime = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        a=1;
        NGAtime -= Time.deltaTime;
        NGAretime = (int)NGAtime;
        if (Input.GetKeyDown(KeyCode.A))
        {
            GameDirector.score += 100;
            Destroy(this.gameObject);
            NGAGenerator.A = 0;
            
        }
       
        

        if(NGAretime==0)
        {
            Destroy(gameObject);
            HPDirector.HP -= 1;
            NGAtime = 5;
            NGAGenerator.A = 0;
            a = 0;
        }

        if(GameDirector.hour==6)
        {
            Destroy(this.gameObject);
        }

    }

}

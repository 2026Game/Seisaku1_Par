using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SocialPlatforms.Impl;

public class GhostDirector : MonoBehaviour
{

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
        }
        else if (Input.anyKeyDown)
        {

        }

    }

}

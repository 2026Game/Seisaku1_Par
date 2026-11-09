using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameDirector.hour==6 || HPDirector.HP==0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("StartScene");
                GameDirector.score = 0;
                GameDirector.retime = 0;
                GameDirector.minute = 0;
                GameDirector.hour = 0;
                GameDirector.stop = 1;
                HPDirector.HP = 3;
            }
        }
    }
}

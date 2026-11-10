using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStartSE : MonoBehaviour
{
    public AudioSource startSE;

    void Start()
    {
        if (SceneManager.GetActiveScene().name == "GameScene")
        {
            startSE.Play();
        }
    }
}
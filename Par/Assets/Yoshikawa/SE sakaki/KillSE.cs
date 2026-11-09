using UnityEngine;

public class KillSE : MonoBehaviour
{
    public AudioSource audioSource;

    int oldScore = 0;

    void Update()
    {
        if (GameDirector.score > oldScore)
        {
            audioSource.Play();
        }

        oldScore = GameDirector.score;
    }
}
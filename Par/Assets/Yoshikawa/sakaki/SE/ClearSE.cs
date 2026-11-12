using UnityEngine;

public class ClearSE : MonoBehaviour
{
    public AudioSource audioSource;

    bool played = false;

    void Update()
    {
        if (GameDirector.hour == 6 && !played)
        {
            audioSource.Play();
            played = true;
        }
    }
}


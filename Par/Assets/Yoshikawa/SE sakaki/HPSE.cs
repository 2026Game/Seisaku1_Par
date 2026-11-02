using UnityEngine;

public class HPSE : MonoBehaviour
{
    public AudioSource audioSource;

    int oldHP = 3;

    void Update()
    {
        if (oldHP > HPDirector.HP)
        {
            audioSource.Play();
        }

        oldHP = HPDirector.HP;
    }
}
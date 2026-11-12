using UnityEngine;

public class HPSE : MonoBehaviour
{
    public AudioSource damageSE;
    public AudioSource heartSE;

    int oldHP = 3;

    void Update()
    {
        if (oldHP > HPDirector.HP)
        {
            damageSE.Play();
        }

        if (HPDirector.HP == 1)
        {
            if (!heartSE.isPlaying)
            {
                heartSE.Play();
            }
        }

        if (HPDirector.HP <= 0)
        {
            heartSE.Stop();
        }

        oldHP = HPDirector.HP;
    }
}
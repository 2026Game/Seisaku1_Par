using UnityEngine;

public class AmbientSound : MonoBehaviour
{
    public AudioSource source;
    public AudioClip[] sounds;

    private float timer;

    void Start()
    {
        SetNextTime();
    }

    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            int index = Random.Range(0, sounds.Length);

            source.PlayOneShot(sounds[index]);

            SetNextTime();
        }
    }

    void SetNextTime()
    {
        timer = Random.Range(5f, 15f);
    }
}
using UnityEngine;

public class NGhostDirectorC : MonoBehaviour
{
    public static int missC = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameDirector.miss = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.C))
        {
            GameDirector.score += 100;
            Destroy(this.gameObject);
            NGCGenerator.C = 0;
            GameDirector.miss = 0;
            missC = 1;
        }
        else if (Input.anyKeyDown)
        {
            GameDirector.miss = 1;
        }
    }
}

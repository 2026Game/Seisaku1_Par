using UnityEngine;

public class NGTGenerator : MonoBehaviour
{
    public GameObject NGTprefab;
    public static int T;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (MoziRandom.ascii == 84)
        {
            if (T <= 2)
            {
                T += 1;
            }
            if (T == 1)
            {
                GameObject obake;
                obake = Instantiate(NGTprefab);
                float x = Random.Range(50, 950);
                float y = Random.Range(50, 450);
                obake.transform.position = new Vector3(x, y, 0);
            }

        }
    }
}

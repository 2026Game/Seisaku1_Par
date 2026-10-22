using UnityEngine;

public class NGNGenerator : MonoBehaviour
{
    public GameObject NGNprefab;
    public static int N;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (MoziRandom.ascii == 78)
        {
            if (N <= 2)
            {
                N += 1;
            }
            if (N == 1)
            {
                GameObject obake;
                obake = Instantiate(NGNprefab);
                float x = Random.Range(50, 950);
                float y = Random.Range(50, 450);
                obake.transform.position = new Vector3(x, y, 0);
            }

        }
    }
}

using UnityEngine;

public class NGKGenerator : MonoBehaviour
{
    public GameObject NGKprefab;
    public static int K;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (MoziRandom.ascii == 75)
        {
            if (K <= 2)
            {
                K += 1;
            }
            if (K == 1)
            {
                GameObject obake;
                obake = Instantiate(NGKprefab);
                float x = Random.Range(50, 950);
                float y = Random.Range(50, 450);
                obake.transform.position = new Vector3(x, y, 0);
            }

        }
    }
}

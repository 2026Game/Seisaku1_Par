using UnityEngine;

public class NGSGenerator : MonoBehaviour
{
    public GameObject NGSprefab;
    public static int S;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (MoziRandom.ascii == 83)
        {
            if (S <= 2)
            {
                S += 1;
            }
            if (S == 1)
            {
                GameObject obake;
                obake = Instantiate(NGSprefab);
                float x = Random.Range(50, 950);
                float y = Random.Range(50, 450);
                obake.transform.position = new Vector3(x, y, 0);
            }

        }
    }
}

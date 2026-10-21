using UnityEngine;

public class NGIGenerator : MonoBehaviour
{
    public GameObject NGIprefab;
    public static int I;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (MoziRandom.ascii == 73)
        {
            if (I <= 2)
            {
                I += 1;
            }
            if (I == 1)
            {
                GameObject obake;
                obake = Instantiate(NGIprefab);
                float x = Random.Range(50, 950);
                float y = Random.Range(50, 450);
                obake.transform.position = new Vector3(x, y, 0);
            }

        }
    }
}

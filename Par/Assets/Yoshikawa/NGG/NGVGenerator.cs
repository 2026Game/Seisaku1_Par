using UnityEngine;

public class NGVGenerator : MonoBehaviour
{
    public GameObject NGVprefab;
    public static int V;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (MoziRandom.ascii == 86)
        {
            if (V <= 2)
            {
                V += 1;
            }
            if (V == 1)
            {
                GameObject obake;
                obake = Instantiate(NGVprefab);
                float x = Random.Range(50, 950);
                float y = Random.Range(50, 450);
                obake.transform.position = new Vector3(x, y, 0);
            }

        }
    }
}

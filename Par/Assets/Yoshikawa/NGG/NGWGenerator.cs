using UnityEngine;

public class NGWGenerator : MonoBehaviour
{
    public GameObject NGWprefab;
    public static int W;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (MoziRandom.ascii == 87)
        {
            if (W <= 2)
            {
                W += 1;
            }
            if (W == 1)
            {
                GameObject obake;
                obake = Instantiate(NGWprefab);
                float x = Random.Range(50, 950);
                float y = Random.Range(50, 450);
                obake.transform.position = new Vector3(x, y, 0);
            }

        }
    }
}

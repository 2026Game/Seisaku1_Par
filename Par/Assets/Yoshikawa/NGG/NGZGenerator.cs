using UnityEngine;

public class NGZGenerator : MonoBehaviour
{
    public GameObject NGZprefab;
    public static int Z;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (MoziRandom.ascii == 90)
        {
            if (Z <= 2)
            {
                Z += 1;
            }
            if (Z == 1)
            {
                GameObject obake;
                obake = Instantiate(NGZprefab);
                float x = Random.Range(50, 950);
                float y = Random.Range(50, 450);
                obake.transform.position = new Vector3(x, y, 0);
            }

        }
    }
}

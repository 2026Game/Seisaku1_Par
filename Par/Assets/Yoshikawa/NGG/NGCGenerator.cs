using UnityEngine;

public class NGCGenerator : MonoBehaviour
{
    public GameObject NGCprefab;
    public static int C;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (MoziRandom.ascii == 67)
        {
            if (C <= 2)
            {
                C += 1;
            }
            if (C == 1)
            {
                GameObject obake;
                obake = Instantiate(NGCprefab);
                float x = Random.Range(50, 950);
                float y = Random.Range(50, 450);
                obake.transform.position = new Vector3(x, y, 0);
            }

        }
    }
}

using UnityEngine;

public class NGDGenerator : MonoBehaviour
{
    public GameObject NGDprefab;
    public static int D;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (MoziRandom.ascii == 68)
        {
            if (D <= 2)
            {
                D += 1;
            }
            if (D == 1)
            {
                GameObject obake;
                obake = Instantiate(NGDprefab);
                float x = Random.Range(50, 950);
                float y = Random.Range(50, 450);
                obake.transform.position = new Vector3(x, y, 0);
            }

        }
    }
}

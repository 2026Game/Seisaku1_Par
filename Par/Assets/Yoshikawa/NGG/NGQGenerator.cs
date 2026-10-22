using UnityEngine;

public class NGQGenerator : MonoBehaviour
{
    public GameObject NGQprefab;
    public static int Q;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (MoziRandom.ascii == 81)
        {
            if (Q <= 2)
            {
                Q += 1;
            }
            if (Q == 1)
            {
                GameObject obake;
                obake = Instantiate(NGQprefab);
                float x = Random.Range(50, 950);
                float y = Random.Range(50, 450);
                obake.transform.position = new Vector3(x, y, 0);
            }

        }
    }
}

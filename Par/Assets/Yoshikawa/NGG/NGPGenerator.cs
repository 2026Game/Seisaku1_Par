using UnityEngine;

public class NGPGenerator : MonoBehaviour
{
    public GameObject NGPprefab;
    public static int P;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (MoziRandom.ascii == 80)
        {
            if (P <= 2)
            {
                P += 1;
            }
            if (P == 1)
            {
                GameObject obake;
                obake = Instantiate(NGPprefab);
                float x = Random.Range(50, 950);
                float y = Random.Range(50, 450);
                obake.transform.position = new Vector3(x, y, 0);
            }

        }
    }
}

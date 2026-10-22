using UnityEngine;

public class NGMGenerator : MonoBehaviour
{
    public GameObject NGMprefab;
    public static int M;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (MoziRandom.ascii == 77)
        {
            if (M <= 2)
            {
                M += 1;
            }
            if (M == 1)
            {
                GameObject obake;
                obake = Instantiate(NGMprefab);
                float x = Random.Range(50, 950);
                float y = Random.Range(50, 450);
                obake.transform.position = new Vector3(x, y, 0);
            }

        }
    }
}

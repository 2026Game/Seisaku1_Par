using UnityEngine;

public class NGEGenerator : MonoBehaviour
{
    public GameObject NGEprefab;
    public static int E;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (MoziRandom.ascii == 69)
        {
            if (E <= 2)
            {
                E += 1;
            }
            if (E == 1)
            {
                GameObject obake;
                obake = Instantiate(NGEprefab);
                float x = Random.Range(50, 950);
                float y = Random.Range(50, 450);
                obake.transform.position = new Vector3(x, y, 0);
            }

        }
    }
}

using UnityEngine;

public class NGFGenerator : MonoBehaviour
{
    public GameObject NGFprefab;
    public static int F;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (MoziRandom.ascii == 70)
        {
            if (F <= 2)
            {
                F += 1;
            }
            if (F == 1)
            {
                GameObject obake;
                obake = Instantiate(NGFprefab);
                float x = Random.Range(50, 950);
                float y = Random.Range(50, 450);
                obake.transform.position = new Vector3(x, y, 0);
            }

        }
    }
}

using UnityEngine;

public class NGUGenerator : MonoBehaviour
{
    public GameObject NGUprefab;
    public static int U;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (MoziRandom.ascii == 85)
        {
            if (U <= 2)
            {
                U += 1;
            }
            if (U == 1)
            {
                GameObject obake;
                obake = Instantiate(NGUprefab);
                float x = Random.Range(50, 950);
                float y = Random.Range(50, 450);
                obake.transform.position = new Vector3(x, y, 0);
            }

        }
    }
}

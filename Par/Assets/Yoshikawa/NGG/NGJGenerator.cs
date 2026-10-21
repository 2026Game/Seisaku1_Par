using UnityEngine;

public class NGJGenerator : MonoBehaviour
{
    public GameObject NGJprefab;
    public static int J;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (MoziRandom.ascii == 74)
        {
            if (J <= 2)
            {
                J += 1;
            }
            if (J == 1)
            {
                GameObject obake;
                obake = Instantiate(NGJprefab);
                float x = Random.Range(50, 950);
                float y = Random.Range(50, 450);
                obake.transform.position = new Vector3(x, y, 0);
            }

        }
    }
}

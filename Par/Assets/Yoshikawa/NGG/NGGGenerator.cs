using UnityEngine;

public class NGGGenerator : MonoBehaviour
{
    public GameObject NGGprefab;
    public static int G;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (MoziRandom.ascii == 71)
        {
            if (G <= 2)
            {
                G += 1;
            }
            if (G == 1)
            {
                GameObject obake;
                obake = Instantiate(NGGprefab);
                float x = Random.Range(50, 950);
                float y = Random.Range(50, 450);
                obake.transform.position = new Vector3(x, y, 0);
            }

        }
    }
}

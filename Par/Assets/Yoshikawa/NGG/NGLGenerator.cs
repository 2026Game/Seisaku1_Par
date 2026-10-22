using UnityEngine;

public class NGLGenerator : MonoBehaviour
{
    public GameObject NGLprefab;
    public static int L;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (MoziRandom.ascii == 76)
        {
            if (L <= 2)
            {
                L += 1;
            }
            if (L == 1)
            {
                GameObject obake;
                obake = Instantiate(NGLprefab);
                float x = Random.Range(50, 950);
                float y = Random.Range(50, 450);
                obake.transform.position = new Vector3(x, y, 0);
            }

        }
    }
}

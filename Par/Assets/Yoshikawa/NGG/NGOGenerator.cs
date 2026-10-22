using UnityEngine;

public class NGOGenerator : MonoBehaviour
{
    public GameObject NGOprefab;
    public static int O;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (MoziRandom.ascii == 79)
        {
            if (O <= 2)
            {
                O += 1;
            }
            if (O == 1)
            {
                GameObject obake;
                obake = Instantiate(NGOprefab);
                float x = Random.Range(50, 950);
                float y = Random.Range(50, 450);
                obake.transform.position = new Vector3(x, y, 0);
            }

        }
    }
}

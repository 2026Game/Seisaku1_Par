using UnityEngine;

public class NGXGenerator : MonoBehaviour
{
    public GameObject NGXprefab;
    public static int X;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (MoziRandom.ascii == 88)
        {
            if (X <= 2)
            {
                X += 1;
            }
            if (X == 1)
            {
                GameObject obake;
                obake = Instantiate(NGXprefab);
                float x = Random.Range(50, 950);
                float y = Random.Range(50, 450);
                obake.transform.position = new Vector3(x, y, 0);
            }

        }
    }
}

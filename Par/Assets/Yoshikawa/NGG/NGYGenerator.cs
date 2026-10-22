using UnityEngine;

public class NGYGenerator : MonoBehaviour
{
    public GameObject NGYprefab;
    public static int Y;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (MoziRandom.ascii == 89)
        {
            if (Y <= 2)
            {
                Y += 1;
            }
            if (Y == 1)
            {
                GameObject obake;
                obake = Instantiate(NGYprefab);
                float x = Random.Range(50, 950);
                float y = Random.Range(50, 450);
                obake.transform.position = new Vector3(x, y, 0);
            }

        }
    }
}

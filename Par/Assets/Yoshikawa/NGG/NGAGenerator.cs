using UnityEngine;

public class NGAGenerator : MonoBehaviour
{
    public GameObject NGAprefab;
    public static int A;
    public static float x;
    public static float y;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (MoziRandom.ascii == 65)
        {
            if (A <= 2)
            {
                A += 1;
            }
            if (A == 1)
            {
                GameObject obake;
                obake = Instantiate(NGAprefab);
                x = Random.Range(50, 950);
                y = Random.Range(50, 450);
                obake.transform.position = new Vector3(x, y, 0);
            }
           
        }
    }
}

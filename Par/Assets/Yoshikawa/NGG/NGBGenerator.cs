using UnityEngine;

public class NGBGenerator : MonoBehaviour
{
    public GameObject NGBprefab;
    public static int B;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (MoziRandom.ascii == 66)
        {
            if (B <= 2)
            {
                B += 1;
            }
            if (B == 1)
            {
                GameObject obakeB;
                obakeB = Instantiate(NGBprefab);
                float x = Random.Range(-830, 740);
                float y = Random.Range(-200, 600);
                obakeB.transform.position = new Vector3(x, y, 0);
            }

        }
    }
}

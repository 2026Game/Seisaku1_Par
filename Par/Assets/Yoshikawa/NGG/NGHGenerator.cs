using UnityEngine;

public class NGHGenerator : MonoBehaviour
{
    public GameObject NGHprefab;
    public static int H;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (MoziRandom.ascii == 72)
        {
            if (H <= 2)
            {
                H += 1;
            }
            if (H == 1)
            {
                GameObject obake;
                obake = Instantiate(NGHprefab);
                float x = Random.Range(50, 950);
                float y = Random.Range(50, 450);
                obake.transform.position = new Vector3(x, y, 0);
            }

        }
    }
}

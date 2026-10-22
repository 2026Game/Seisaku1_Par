using UnityEngine;

public class NGRGenerator : MonoBehaviour
{
    public GameObject NGRprefab;
    public static int R;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (MoziRandom.ascii == 82)
        {
            if (R <= 2)
            {
                R += 1;
            }
            if (R == 1)
            {
                GameObject obake;
                obake = Instantiate(NGRprefab);
                float x = Random.Range(50, 950);
                float y = Random.Range(50, 450);
                obake.transform.position = new Vector3(x, y, 0);
            }

        }
    }
}

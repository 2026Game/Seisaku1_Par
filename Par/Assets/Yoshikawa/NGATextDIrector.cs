using UnityEngine;
using TMPro;

public class NGATextDIrector : MonoBehaviour
{
    public GameObject textPrefab;   // TextMeshPro ‚ÌƒvƒŒƒnƒu
    public Transform canvasTransform; // Canvas ‚Ì Transform
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (NGAGenerator.A == 1)
        {
            GameObject textObj = Instantiate(textPrefab, canvasTransform);
            textObj.transform.position = new Vector3(NGAGenerator.x, NGAGenerator.y, 0);
        }
        textPrefab.GetComponent<TextMeshProUGUI>().text =
           GhostDirector.NGAretime.ToString();
    }
}

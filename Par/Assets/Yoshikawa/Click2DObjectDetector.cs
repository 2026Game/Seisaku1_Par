using UnityEngine;
using UnityEngine.SceneManagement;

public class Click2DObjectDetector : MonoBehaviour
{
    public LayerMask clickableLayer = ~0; // 全レイヤー対象（必要に応じて設定）

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            DetectClickedObject2D();
        }
    }

    void DetectClickedObject2D()
    {
        // マウス位置をワールド座標に変換
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Raycastでクリック対象を検知
        RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero, 0f, clickableLayer);

        if (hit.collider != null)
        {
            SceneManager.LoadScene("GameScene");
        }
        else
        {
            Debug.Log("No clickable 2D object detected.");
        }
    }
}

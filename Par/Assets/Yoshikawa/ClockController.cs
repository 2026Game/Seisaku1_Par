using UnityEngine;

public class ClockController : MonoBehaviour
{
    public float rotationSpeed = 500f; // ‰ñ“]‘¬“x

    void Update()
    {
        if (GameDirector.hour < 6)
        {
            transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
        }
    }
}

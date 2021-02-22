using UnityEngine;

public class SkyRotation : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(0f, 0f, 1f) * Time.deltaTime);
    }
}

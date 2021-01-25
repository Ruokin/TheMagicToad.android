using UnityEngine;

public class Boundaries : MonoBehaviour
{
    private Vector2 screenBounds;
    private Vector2 boundPos;

    void Start()
    {
        //Defining of screen bounds
        screenBounds =
            Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        boundPos = GameObject.FindWithTag("Boundary").transform.position;

    }
    
    public void Boundary()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -screenBounds.x, screenBounds.x),
                Mathf.Clamp(transform.position.y, -screenBounds.y, boundPos.y), transform.position.z);
    }
}

using UnityEngine;

public class FlyDeathScript : MonoBehaviour
{
    
    void Start()
    {
        Destroy(gameObject, Time.deltaTime * 50f);
    }

}

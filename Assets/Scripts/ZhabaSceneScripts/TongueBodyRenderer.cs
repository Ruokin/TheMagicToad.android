using System.Collections.Generic;
using UnityEngine;

public class TongueBodyRenderer : MonoBehaviour
{
    public GameObject go1;
    public GameObject go2;
    LineRenderer l;
    public Material newMaterial;
    
    void Start()
    {
        l = gameObject.AddComponent<LineRenderer>();

    }
    
    void Update()
    {
        List<Vector3> pos = new List<Vector3>();
        pos.Add(go1.transform.position);
        pos.Add(go2.transform.position);
        l.startWidth = 0.2f;
        l.endWidth = 0.2f;
        l.material = newMaterial;
        l.startColor = Color.red;
        l.endColor = Color.red;
        l.SetPositions(pos.ToArray());
        l.useWorldSpace = true;
        l.sortingOrder = 1;
    }
}

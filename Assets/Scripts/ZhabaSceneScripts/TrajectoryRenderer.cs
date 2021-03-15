using System.Collections;
using UnityEngine;

public class TrajectoryRenderer : MonoBehaviour
{
    public GameObject PointPrefab;
    public GameObject[] Points;
    public GameObject TongueStart;
    public GameObject TongueEnd;
    public Vector2 Direction;
    public float force;

    public int numberOfPoints;
    
    
    public void SpawnTrajectory()
    {
        Points = new GameObject[numberOfPoints];
        
        for (int i = 0; i < numberOfPoints; i++)
        { 
            Points[i] = Instantiate(PointPrefab, transform.position, Quaternion.identity);
        }
    }

    public void DestroyTrajectory()
    {
        for (int i = 0; i < numberOfPoints; i++)
        {
            Destroy(Points[i]);
        }
    }

    public void Trajectory()
    {
        
        Vector2 tsPOS = TongueStart.transform.position;
        Vector2 tePOS = TongueEnd.transform.position;

        Direction = tsPOS - tePOS;

        for (int i = 0; i < numberOfPoints; i++)
        {
            Points[i].transform.position = PointPos(i * 0.1f);
        }
    }

    Vector2 PointPos(float t)
    {
        Vector2 currentPointPos = (Vector2)transform.position + (Direction.normalized * force * t);
        return currentPointPos;
    }
    
}

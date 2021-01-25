using System.Collections;
using UnityEngine;

public class FlySpawnRight : MonoBehaviour
{
    public GameObject[] FlyHive;
    public GameObject[] PoisonHive;
    private GameObject FlyObj;
    private Vector2 SpawnLeftPos;
    private float randPositionY;

    void Start()
    {
        SpawnLeftPos = transform.position;
        StartCoroutine("Spawn");
        StartCoroutine("SpawnPoison");
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            randPositionY = Random.Range(-0.5f, 0.5f);
            FlyObj = Instantiate(FlyHive[0], SpawnLeftPos + new Vector2(0f,randPositionY), Quaternion.identity) as GameObject;
            yield return new WaitForSeconds(2f);  
        }
    }
    
    IEnumerator SpawnPoison()
    {
        while (true)
        {
            yield return new WaitForSeconds(14f); 
            randPositionY = Random.Range(-0.5f, 0.5f);
            FlyObj = Instantiate(PoisonHive[0], SpawnLeftPos + new Vector2(0f,randPositionY), Quaternion.identity) as GameObject;
        }
    }
}
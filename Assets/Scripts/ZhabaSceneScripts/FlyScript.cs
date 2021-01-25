using UnityEngine;

public class FlyScript : MonoBehaviour
{
    public GameObject FlyDeath;
    public Vector2 FlyPos;
    public float Speed = 500f;
    public float randY;
    public Vector2 SpawnPos;
    public int X;

    Rigidbody2D rb2d;
    Collider2D col2d;

    void Start()
    {
        SpawnPos = transform.position;

        if (SpawnPos.x > 1)
        {
            X = -1;
            transform.localScale = transform.localScale + (Vector3.left * 4);
        }
        
        if (SpawnPos.x < 1)
        {
            X = 1;
        }
        
        rb2d = GetComponent<Rigidbody2D>();
        randY = Random.Range(-0.5f, 0.5f);
        Vector2 movement = new Vector2(X, randY);
        rb2d.AddForce(movement * Speed);
    }

    void FixedUpdate()
    {
        FlyPos = transform.position;
    }
    
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Tongue")
        {
            //Death after collide with tongue
            FlyDeath.transform.position = FlyPos;
            Instantiate(FlyDeath);
            Destroy(gameObject);
        }
        
        if (col.gameObject.tag == "FlySpawn")
        {
            Destroy(gameObject);
        }

    }
}
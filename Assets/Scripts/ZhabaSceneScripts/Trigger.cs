using UnityEngine;

public class Trigger : MonoBehaviour
{
    public Rigidbody2D TongRB;
    public bool i = true; //Переменная для проверки достижения стартовой позиции
    public Vector2 TrigReturn;
    const float MIN_RANGE = 0.1f; // Дистанция до стартовой позиции

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Tongue")
        {
            if (i == true)
            {
                //Заморозка движения языка
                TongRB.constraints = RigidbodyConstraints2D.FreezePosition;
                TongRB.WakeUp();
                TongRB.constraints &= ~RigidbodyConstraints2D.FreezePosition;
                i = false;
            }
        }
    }

    void Update()
    {
        TrigReturn = TongueScript.GV.ReturnPos;
        TongRB = GameObject.FindWithTag("Tongue").GetComponent<Rigidbody2D>();
        if (i != true)
        {
            //Движение на старт
            GameObject.FindWithTag("Tongue").transform.position = Vector3.Lerp
            (GameObject.FindWithTag("Tongue").transform.position,
                TrigReturn,
                Time.deltaTime * 5f);  
        }

        //Проверка достижения стартовой позиции
        if (Vector2.Distance(TrigReturn,GameObject.FindWithTag("Tongue").transform.position) < MIN_RANGE)
        {
            i = true;
        }
    }
}
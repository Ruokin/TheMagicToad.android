using System.Collections;
using UnityEngine;

public class TongueScript : MonoBehaviour
{
    public Vector2 StartPos { get; set; }
    public Rigidbody2D TongRB;
    public bool i = false; //Checking for reaching starting position
    public Vector2 TrigReturn;
    const float MIN_RANGE = 0.1f; // Distance to starting position
    public GameManager gm;
    public float restartDelay = 1f;
    
    public int maxHealth = 1000; // So much health for smoother damage dealing
    public int currentHealth;
    public HealthbarScript Healthbar;
    
    public Animator animator;
    public PlayerStats playerStats;


    public static class GV //Global Variable
    {
        public static Vector2 ReturnPos;
    }

    void Start()
    {
        StartPos = transform.position;
        GV.ReturnPos = transform.position;
        currentHealth = maxHealth;
        Healthbar.SetMaxHealth(maxHealth);
        StartCoroutine("DamageForSec");
    }
    
    void Update()
    {
        //Returning to starting position
        TrigReturn = TongueScript.GV.ReturnPos;
        TongRB = GameObject.FindWithTag("Tongue").GetComponent<Rigidbody2D>();
        if (i != false)
        {
            GameObject.FindWithTag("Tongue").transform.position = Vector3.Lerp
            (GameObject.FindWithTag("Tongue").transform.position,
                TrigReturn,
                Time.deltaTime * 8f);
        }

        //Reaching starting position check
        if (Vector2.Distance(TrigReturn,GameObject.FindWithTag("Tongue").transform.position) < MIN_RANGE)
        {
            i = false;
            animator.SetBool("anEat",false);
            animator.SetBool("anIdle",true);
        }

        if (currentHealth <= 0)
        {
            Invoke("Restart", restartDelay);
        }
    }
    
    //Will rewrite it later
    void OnCollisionEnter2D(Collision2D col)
    {
        //Freezing tongue after collide with fly
        if (col.gameObject.tag == "Fly")
        {
            animator.SetBool("anBack",false);
            animator.SetBool("anEat",true);
            gm.mushki += gm.mushkiPerClick;
            TakeHeal(80);
            if (i == false)
            {
                TongRB.constraints = RigidbodyConstraints2D.FreezePosition;
                TongRB.WakeUp();
                TongRB.constraints &= ~RigidbodyConstraints2D.FreezePosition;
                i = true;
            }
        }
        
        if (col.gameObject.tag == "FlyPoison")
        {
            animator.SetBool("anBack",false);
            animator.SetBool("anEat",true);
            if (gm.mushki < 10)
            {
                gm.mushki = 0;
            }
            else
            {
                gm.mushki -= 10 * gm.mushkiPerClick;
            }
            TakeDamage(160);
            if (i == false)
            {
                TongRB.constraints = RigidbodyConstraints2D.FreezePosition;
                TongRB.WakeUp();
                TongRB.constraints &= ~RigidbodyConstraints2D.FreezePosition;
                i = true;
            }
        }
    }
    
    void TakeDamage(int damage)
    {
        if (playerStats.TutorialEnded == true)
        {
            currentHealth -= damage;
            Healthbar.SetHealth(currentHealth);
        }
    }
    
    void TakeHeal(int heal)
    {
        currentHealth += heal;
        Healthbar.SetHealth(currentHealth);
    }
    
    private void Restart()
    {
        FindObjectOfType<GameOverPopUp>().GameOver();
    }
    
    IEnumerator DamageForSec()
    {
        while (true)
        {
            TakeDamage(5);
            yield return new WaitForSeconds(0.1f);  
        }
    }
    
}
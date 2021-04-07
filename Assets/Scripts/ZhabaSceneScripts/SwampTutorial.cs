using UnityEngine;
using UnityEngine.UI;

public class SwampTutorial : MonoBehaviour
{
    public GameObject Tutorial;
    public GameObject CatPopUp;
    public GameObject PointerFinger;
    public Animator Health;
    public Text CatText;
    public int TutorialStep = 0;
    public bool TutorialEnded;
    
    public PlayerStats playerStats;

    public void Start()
    {
        playerStats.LoadStats();
        TutorialEnded = playerStats.TutorialEnded;
        
        if (TutorialEnded == false)
        {
           
            CatPopUp.SetActive(true);
            TutorialStep += 1;
        }
        else
        {
            Tutorial.SetActive(false);
        }
        
    }

    public void Update()
    {
        switch(TutorialStep)
        {
            case 1:
                Health.SetBool("HealthTutLight", true);
                CatText.text = "The line on top is your remaining time.";
                break;
            case 2:
                CatText.text = "When it became zero, you will return to tower.";
                break;
            case 3:
                CatText.text = "Eat flies to collect them and expand time.";
                break;
            case 4:
                Health.SetBool("HealthTutLight", false);
                CatText.text = "Pull the tongue down and then release it to catch a fly.";
                PointerFinger.SetActive(true);
                break;
            case 5:
                CatText.text = "The further you pull the tongue, the faster it will move.";
                break;
            case 6:
                PointerFinger.SetActive(false);
                TutorialEnded = true;
                playerStats.TutorialEnded = TutorialEnded;
                playerStats.SaveStats();

                Tutorial.SetActive(false);
                CatPopUp.SetActive(false);
                break;
        }
    }
    
    public void NextButton()
    {
        TutorialStep += 1;
    }
}

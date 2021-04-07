using UnityEngine;
using UnityEngine.UI;

public class FirstStart : MonoBehaviour
{
    //Start
    public GameObject firstStart;
    public GameObject Buttons; //All UI buttons
    public GameObject CatButton;
    public GameObject CatbuttonSprite;
    public GameObject CatPopUp;
    public Text CatText;
    public bool TutorialEnded = false;
    public int TutorialStep = 0;
    
    //Cleaning
    public GameObject Broom;
    public GameObject BroomButton;
    public GameObject ParticlesBroom;
    public GameObject ParticlesWindows;
    public GameObject[] Trash;
    public Animator broomAnim;
    public bool BParticlesSpawned = false;

    //Windows
    public GameObject ClosedWindows;
    public GameObject WindowsButton;
    public Animator windowsAnim;
    public bool WParticlesSpawned = false;
    public int WindowsStep = 0;
    
    //Portal
    public GameObject ClosedPortal;
    public GameObject ClosedPortalButton;
    public GameObject PortalParts;
    public GameObject PortalPlanks;
    public GameObject PortalButton;
    public GameObject ClosedPortalParticles;
    public Animator portalAnim;
    public bool CPParticlesSpawned = false;
    
    public PlayerStats playerStats;
    
    

    void Start()
    {
        playerStats.LoadStats();
        TutorialEnded = playerStats.TutorialEnded;
        
        if (TutorialEnded == false)
        {
            for (int i = 0; i < Trash.Length; i++)
            {
                Instantiate(Trash[i]);
            }
            Buttons.SetActive(false);
            PortalParts.SetActive(false);
            ClosedPortal.SetActive(true);
            ClosedWindows.SetActive(true);
            CatButton.SetActive(true);
            CatbuttonSprite.SetActive(true);
            Broom.SetActive(true);
        }
        else
        {
            firstStart.SetActive(false);
        }
    }

    void Update()
    {
        switch (TutorialStep)
        {
            case 1:
                CatText.text = "This tower is very dirty.";
                break;
            case 2:
                CatText.text = "How do you live here?";
                break;
            case 3:
                CatText.text = "Let's do some cleaning. Use this broom!";
                broomAnim.SetInteger("BroomAnimTransit", 1);
                if (BParticlesSpawned == false)
                {
                    Instantiate(ParticlesBroom);
                    BParticlesSpawned = true;
                }
                break;
            case 4:
                BroomButton.SetActive(true);
                CatPopUp.SetActive(false);
                break;
            case 5:
                CatPopUp.SetActive(true);
                CatText.text = "Good job!";
                break;
            case 6:
                CatText.text = "Now open windows!";
                break;
            case 7:
                if (WParticlesSpawned == false)
                { 
                    Instantiate(ParticlesWindows);
                    WParticlesSpawned = true;
                }
                WindowsButton.SetActive(true);
                CatPopUp.SetActive(false);
                WindowsStep += 1;
                TutorialStep += 1;
                break;
            case 8:
                break;
            case 9:
                ClosedWindows.SetActive(false);
                CatPopUp.SetActive(true);
                CatText.text = "The tower is much brighter now.";
                break;
            case 10:
                CatText.text = "But look at this well.";
                break;
            case 11:
                CatText.text = "Open it too, at least you'll have some free water.";
                break;
            case 12:
                CatPopUp.SetActive(false);
                ClosedPortalButton.SetActive(true);
                portalAnim.SetInteger("PortalAnimTransit", 1);
                if (CPParticlesSpawned == false)
                {
                    Instantiate(ClosedPortalParticles);
                    CPParticlesSpawned = true;
                }

                break;
            case 13:
                CatText.text = "Wow! It seems that this well is one of those old magic portals!";
                break;
            case 14:
                CatText.text = "No one knows what's on the other side... ";
                break;
            case 15:
                CatText.text = "Maybe some food or good stuff...";
                break;
            case 16:
                PortalButton.SetActive(true);
                CatPopUp.SetActive(false);
                break;
        }

        switch (WindowsStep)
        {
            case 1:
                windowsAnim.SetInteger("WindowsAnimTransit", 1);
                break;
            case 2:
                windowsAnim.SetInteger("WindowsAnimTransit", 2);
                break;
            case 3:
                windowsAnim.SetInteger("WindowsAnimTransit", 3);
                break;
            case 4:
                WindowsButton.SetActive(false);
                windowsAnim.SetInteger("WindowsAnimTransit", 4);
                break;
        }
    }
    
    public void NextButton()
    {
        TutorialStep += 1;
    }

    public void CatButtonDown()
    {
        TutorialStep += 1;
        CatPopUp.SetActive(true);
        CatbuttonSprite.SetActive(false);
        CatButton.SetActive(false);
    }

    public void BroomButtonDown()
    {
        Destroy(GameObject.FindGameObjectWithTag("Particles"));
        broomAnim.SetInteger("BroomAnimTransit", 2);
        BroomButton.SetActive(false);
    }

    public void WindowsButtonDown()
    {
        Destroy(GameObject.FindGameObjectWithTag("Particles"));
        WindowsStep += 1;
    }

    public void ClosedPortalButtonDown()
    {
        Destroy(GameObject.FindGameObjectWithTag("Particles"));
        portalAnim.SetInteger("PortalAnimTransit", 2);
        ClosedPortalButton.SetActive(false);
        ClosedPortal.SetActive(false);
        PortalPlanks.SetActive(true);
    }
}

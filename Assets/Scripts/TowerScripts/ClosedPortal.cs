using UnityEngine;

public class ClosedPortal : MonoBehaviour
{
    public FirstStart Firststart;
    public GameObject trashParticlesPortal;
    public GameObject trashParticlesPortal2;
    
    public void OpenPortal()
    {
        Firststart.PortalParts.SetActive(true);
        Firststart.CatPopUp.SetActive(true);
        Firststart.TutorialStep += 1;
        Firststart.ClosedPortalButton.SetActive(false);
        Firststart.PortalPlanks.SetActive(false);
    }

    public void SpawnParticles1()
    {
        Instantiate(trashParticlesPortal);
    }

    public void SpawnParticles2()
    {
        Instantiate(trashParticlesPortal2);
    }

    public void DeleteParticles()
    {
        Destroy(GameObject.FindGameObjectWithTag("trashParticles"));
    }
    
}

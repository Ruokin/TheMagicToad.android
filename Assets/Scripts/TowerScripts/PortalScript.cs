using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalScript : MonoBehaviour
{
    public GameObject PortalMenuUI;


    public void Portal()
    {
        PortalMenuUI.SetActive(true);
    }
    
    public void Swamp()
    {
        SceneManager.LoadScene("Zhaba");
    }
    
    public void Close()
    {
        PortalMenuUI.SetActive(false);
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalScript : MonoBehaviour
{
    public GameObject PortalMenuUI;
    public GameObject PortalParts;
    
    
    public void Portal()
    {
        Instantiate(PortalParts);
        PortalMenuUI.SetActive(true);
        Time.timeScale = 0f;
    }
    
    public void Swamp()
    {
        SceneManager.LoadScene("Zhaba");
        Time.timeScale = 1f;
    }
    
    public void Close()
    {
        PortalMenuUI.SetActive(false);
        Time.timeScale = 1f;
    }
}

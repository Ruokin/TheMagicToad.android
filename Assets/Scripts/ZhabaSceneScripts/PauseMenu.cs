using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject PauseMenuUI;

    public void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Menu()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene("PFTower");
    }

    public void Close()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
    }
}

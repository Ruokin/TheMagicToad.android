using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverPopUp : MonoBehaviour
{
    private bool GameEnded = false;
    public GameObject GameOverMenuUI;

    public void GameOver()
    {
        if (GameEnded == false)
        {
            GameOverMenuUI.SetActive(true);
            Time.timeScale = 0f;
            GameEnded = true;
        }
    }

    public void Restart()
    {
        GameOverMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameEnded = false;
        SceneManager.LoadScene("Zhaba");
    }

    public void Menu()
    {
        GameOverMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameEnded = false;
        SceneManager.LoadScene("PFTower");
    }
    
    public void DoubleScore()
    {
        
    }
}

using UnityEngine;

public class DebugCheats : MonoBehaviour
{
    public PlayerStats _playerStats;
    public GameObject DebugMenuUI;

    public void OpenMenu()
    {
        DebugMenuUI.SetActive(true);
    }
    
    public void CloseMenu()
    {
        DebugMenuUI.SetActive(false);
    }
    
    public void DeleteMoney()
    {
        _playerStats.money = 0;
        _playerStats.SaveStats();
    }
    
    public void GetMoney()
    {
        _playerStats.money += 1000;
        _playerStats.SaveStats();
    }

    public void LoadTutorial()
    {
        _playerStats.TutorialEnded = false;
        _playerStats.SaveStats();
    }
}

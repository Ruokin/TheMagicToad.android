using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TowerManager : MonoBehaviour
{
    public Text moneyDisplay;
    public int money;
    
    public PlayerStats playerStats;
    public GameObject TowerShopMenuUI;

    void Start()
    {
        playerStats.LoadStats();
    }
    
    void Update()
    {
        money = playerStats.money;
        moneyDisplay.text = "" + money;
    }
    
    public void OpenTowerMenu()
    {
        TowerShopMenuUI.SetActive(true);
      
    }
   
    public void Close()
    {
        TowerShopMenuUI.SetActive(false);
    }
}

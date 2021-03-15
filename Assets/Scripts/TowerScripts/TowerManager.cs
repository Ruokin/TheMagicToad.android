using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TowerManager : MonoBehaviour
{
    public Text moneyDisplay;
    public int money = 0;
    public PlayerStats playerStats;

    void Start()
    {
        playerStats.LoadStats();
        money = playerStats.money;
    }
    
    void Update()
    {
        moneyDisplay.text = "" + money;
    }
}

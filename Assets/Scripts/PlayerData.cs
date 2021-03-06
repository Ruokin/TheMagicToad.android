﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int wearedHatID;
    public int money;
    public bool TutorialEnded;
    
    public PlayerData (PlayerStats playerStats)
    {
        wearedHatID = playerStats.wearedHatID;
        money = playerStats.money;
        TutorialEnded = playerStats.TutorialEnded;
    }
}

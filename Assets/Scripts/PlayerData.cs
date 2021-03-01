using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int wearedHatID;

    public PlayerData (HatDisplay hatDisplay)
    {
        wearedHatID = hatDisplay.hatID;
    }
}

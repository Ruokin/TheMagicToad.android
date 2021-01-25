using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int Money;
    public int SelectedHat;
    public bool MageHatOpened;

    public PlayerData(ItemsMngr itemsMngr)
    {
        SelectedHat = itemsMngr.SelectedHat;
        MageHatOpened = itemsMngr.MageHatOpened;
    }

}

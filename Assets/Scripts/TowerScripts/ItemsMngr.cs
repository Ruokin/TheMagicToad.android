using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsMngr : MonoBehaviour
{
    //Testing script for inventory items manager
    public int SelectedHat = 0;
    public bool MageHatOpened = false;

    public void MageHat()
    {
        if (MageHatOpened == true)
        { 
            SelectedHat = 1;
        }
        
    }
}

﻿using UnityEngine;
using UnityEngine.UI;

public class HatDisplay : MonoBehaviour
{
    public Hat hat;

    public Text nameText;
    public Text descriptionText;

    public Image hatImage;

    public GameObject putOnButton;
    public GameObject inTowerHat;
    public int hatID;

    public PlayerStats playerStats;
    

    void Start()
    {
        playerStats.LoadStats();
        
        if (hat.active == true)
        {
            nameText.text = hat.name;
            descriptionText.text = hat.description;
            
            hatImage.sprite = hat.activeImage;
            
            putOnButton.SetActive(true);
        }

        else
        {  
            hatImage.sprite = hat.disactiveImage;
            putOnButton.SetActive(false);
        }
    }

    public void PutOnHat()
    {
        inTowerHat.GetComponent<SpriteRenderer>().sprite = hat.inTowerImage;
        hatID = hat.id;
        playerStats.wearedHatID = hatID;
        
        playerStats.SaveStats();
        
    }
}

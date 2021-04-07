using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
   public int wearedHatID {get; set;}
   public int money {get; set;}
   public bool TutorialEnded {get; set;}

   public void SaveStats()
   {
      SaveSystem.SaveStats(this);
   }

   public void LoadStats()
   {
      PlayerData data = SaveSystem.LoadStats();

      wearedHatID = data.wearedHatID;
      money = data.money;
      TutorialEnded = data.TutorialEnded;
   }
}
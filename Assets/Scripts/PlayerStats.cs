using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
   public int wearedHatID;
   public int money;

   public void SaveStats()
   {
      SaveSystem.SaveStats(this);
   }

   public void LoadStats()
   {
      PlayerData data = SaveSystem.LoadStats();

      wearedHatID = data.wearedHatID;
      money = data.money;
   }
}
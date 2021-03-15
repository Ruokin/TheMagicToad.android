using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
   public static void SaveStats(PlayerStats playerStats)
   {
      BinaryFormatter formatter = new BinaryFormatter();
      
      string path = Application.persistentDataPath + "/player.stats";
      FileStream stream = new FileStream(path, FileMode.Create);
      
      PlayerData data = new PlayerData(playerStats);
      
      formatter.Serialize(stream, data);
      
      stream.Close();
   }
   
   public static PlayerData LoadStats()
   {
      string path = Application.persistentDataPath + "/player.stats";

      if (File.Exists(path))
      {
         BinaryFormatter formatter = new BinaryFormatter();
         FileStream stream = new FileStream(path, FileMode.Open);

         PlayerData data = formatter.Deserialize(stream) as PlayerData;
         stream.Close();

         return data;
      }
      else
      {
         Debug.LogError("Save file not found " + path);
         return null;
      }
   }
}

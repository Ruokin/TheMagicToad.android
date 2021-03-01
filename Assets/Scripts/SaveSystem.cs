using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
   public static void SaveHat(HatDisplay hatDisplay)
   {
      BinaryFormatter formatter = new BinaryFormatter();
      
      string path = Application.persistentDataPath + "/player.hat";
      FileStream stream = new FileStream(path, FileMode.Create);
      
      PlayerData data = new PlayerData(hatDisplay);
      
      formatter.Serialize(stream, data);
      
      stream.Close();
   }

   public static PlayerData LoadHat()
   {
      string path = Application.persistentDataPath + "/player.hat";

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
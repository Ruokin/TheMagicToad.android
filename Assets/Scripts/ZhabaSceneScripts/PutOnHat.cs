using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PutOnHat : MonoBehaviour
{
    public int wearedHatID;
    public List<Sprite> hats;
    public Sprite hat;

    void Start()
    {
        PlayerData data = SaveSystem.LoadHat();
        wearedHatID = data.wearedHatID;

        switch (wearedHatID)
        {
            case 0:
                break;
            case 1:
                hat = hats.ElementAt(1);
                break;
            case 2:
                hat = hats.ElementAt(2);
                break;
            case 3:
                hat = hats.ElementAt(3);
                break;
            case 4:
                hat = hats.ElementAt(4);
                break;
            case 5:
                hat = hats.ElementAt(5);
                break;
            case 6:
                hat = hats.ElementAt(6);
                break;
        }
        
        GetComponent<SpriteRenderer>().sprite = hat;
    }
}

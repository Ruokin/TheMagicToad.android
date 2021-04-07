using UnityEngine;

[CreateAssetMenu(fileName = "New furniture", menuName = "Furniture")]

public class Furniture : ScriptableObject
{
    public new string name;
    public string description;
    public bool active;
    public int id;

    public Sprite disactiveImage;
    public Sprite activeImage;
    public Sprite inTowerImage;
}

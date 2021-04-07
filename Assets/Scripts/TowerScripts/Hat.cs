using UnityEngine;

[CreateAssetMenu(fileName = "New hat", menuName = "Hat")]
public class Hat : ScriptableObject
{
    public new string name;
    public string description;
    public bool active;
    public int id;

    public Sprite disactiveImage;
    public Sprite activeImage;
    public Sprite inTowerImage;
    public Sprite inGameImage;
}

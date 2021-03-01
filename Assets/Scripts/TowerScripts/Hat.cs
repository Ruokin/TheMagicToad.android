using UnityEngine;

[CreateAssetMenu(fileName = "New hat", menuName = "Hat")]
public class Hat : ScriptableObject
{
    public new string name;
    public string description;
    [SerializeField]
    public bool active;
    [SerializeField]
    public int id;

    public Sprite disactiveImage;
    public Sprite activeImage;
    public Sprite inTowerImage;
    [SerializeField]
    public Sprite inGameImage;
}

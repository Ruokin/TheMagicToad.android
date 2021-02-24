using UnityEngine;

public class HatsDescriptionMngr : MonoBehaviour
{
    public GameObject DescriptionUI;

    public void Selected()
    {
        DescriptionUI.SetActive(true);
    }
    
    public void Deselected()
    {
        DescriptionUI.SetActive(false);
    }
}

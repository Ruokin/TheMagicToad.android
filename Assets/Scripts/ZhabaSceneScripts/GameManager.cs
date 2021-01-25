using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text mushkiDisplay;
    public Text mushkiDisplayFinal;
    public float mushki = 0;
    public float mushkiPerClick = 1;
    

    void Update()
    {
        mushkiDisplay.text = "Flies: " + mushki;
        mushkiDisplayFinal.text = "" + mushki;
    }

}
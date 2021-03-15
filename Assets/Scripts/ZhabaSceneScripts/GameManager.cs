using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text mushkiDisplay;
    public Text mushkiDisplayFinal;
    public int mushki = 0;
    public int mushkiPerClick = 1;
   
    

    void Update()
    {
        mushkiDisplay.text = "Flies: " + mushki;
        mushkiDisplayFinal.text = "" + mushki;
    }

}
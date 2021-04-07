using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosedWindows : MonoBehaviour
{
    public FirstStart firstStart;

    public void TutorialStep()
    {
        firstStart.TutorialStep += 1;
    }
    
}

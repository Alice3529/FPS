using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSBooster : MonoBehaviour
{
    int target = 60;

    private void Update()
    {
        if (Application.targetFrameRate != target)
        {
            Application.targetFrameRate = target; //Specifies the frame rate at which Unity tries to render game.
        }
    }
}

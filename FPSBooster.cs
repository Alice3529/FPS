using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSBooster : MonoBehaviour
{
    int target = Screen.currentResolution.refreshRate;

    private void Update()
    {
        if (Application.targetFrameRate != target)
        {
            Application.targetFrameRate = target;
        }
    }

}

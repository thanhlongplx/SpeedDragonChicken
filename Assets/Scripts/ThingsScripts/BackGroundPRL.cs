using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundPRK : MonoBehaviour
{
    public Transform mainCam;
    public Transform midBg;
    public Transform sideBg;
    public float length;
    void Update()
    {
        if (mainCam.position.x > midBg.position.x)
        {
            UpdateBackgroundPosition(Vector3.right);
        }
        else if (mainCam.position.x < midBg.position.x)
        {
            UpdateBackgroundPosition(Vector3.left);
        }
    }
    void UpdateBackgroundPosition(Vector3 direction)
    {

        sideBg.position = midBg.position + direction * length;
        Transform temp = midBg;
        midBg = sideBg;
        sideBg = temp;
    }
}

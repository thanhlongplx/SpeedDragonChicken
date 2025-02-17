using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG_tPlayer : MonoBehaviour
{
    public Transform mainCam;
public Transform midBg;
public Transform sideBg;
public float speed = 6.0f; // Thêm biến speed để điều chỉnh tốc độ

void Update()
{
    UpdateBackgroundPosition();
}

void UpdateBackgroundPosition()
{
    Vector3 camPos = mainCam.position;
    Vector3 midBgPos = midBg.position;

    if (camPos.x > midBgPos.x)
    {
        UpdateSideBgPosition(Vector3.right);
    }
    else if (camPos.x < midBgPos.x)
    {
        UpdateSideBgPosition(Vector3.left);
    }

    if (camPos.y > midBgPos.y)
    {
        UpdateSideBgPosition(Vector3.up);
    }
    else if (camPos.y < midBgPos.y)
    {
        UpdateSideBgPosition(Vector3.down);
    }
}

void UpdateSideBgPosition(Vector3 direction)
{
    sideBg.position = midBg.position + direction * speed * (Time.deltaTime*8);

    // Hoán đổi vị trí của midBg và sideBg
    Transform temp = midBg;
    midBg = sideBg;
    sideBg = temp;
}
}

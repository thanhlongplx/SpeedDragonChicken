using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GàLửa : MonoBehaviour
{
    private bool isMovingRight = true;

    private float speed = 4f;
    public float X;
    public float temp;
    public float directionX;
    public float moveSpace;
    private UIManager UI;
    private Move move;
    public int solanCham = 5;
    public int giamlanCham;

    void Start()
    {
        UI = FindObjectOfType<UIManager>();
        move = FindObjectOfType<Move>();
        giamlanCham = solanCham;
        temp = directionX;
    }

    void Update()
    {
        if (!UI.showPauseMenu)
        {
            MoveAndFlip();
        }
        if (giamlanCham == 0)
        {
            UI.showthongBaoGaLua(true);
            UI.showPauseMenu = true;
            directionX= 0;
        }

    }

    void MoveAndFlip()
    {
        float currentX = transform.position.x;

        if (currentX >= (X + moveSpace))
        {
            Flip();
            isMovingRight = !isMovingRight; // Đảo ngược hướng di chuyển
        }
        if (currentX <= (X - moveSpace))
        {
            Flip();
            isMovingRight = !isMovingRight;
        }

        directionX = isMovingRight ? 1f : -1f;
        transform.Translate(Vector2.right * directionX * speed * Time.deltaTime);
    }

    void Flip()
    {
        Vector3 localScale = transform.localScale;
        localScale.x *= -1f;
        transform.localScale = localScale;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GaBeoBu : MonoBehaviour
{
    private bool isMovingRight = true;

    private float speed = 4f;
    public float X;
    public float directionX;
    public float moveSpace;
    private UIManager UI;

    void Start()
    {
        UI = FindObjectOfType<UIManager>();
    }

    void Update()
    {
        if (!UI.showPauseMenu)
        {
            MoveAndFlip();
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

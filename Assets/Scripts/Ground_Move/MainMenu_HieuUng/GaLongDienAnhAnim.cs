using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GaLongDienAnhAnim : MonoBehaviour
{
    private bool isMovingRight = true;
    private float speed = 20f;
    private float maxX = 25f;

    void Update()
    {
        MoveAndFlip();
    }

    void MoveAndFlip()
    {
        float currentX = transform.position.x;

        if (currentX >= maxX || currentX <= -maxX)
        {
            Flip();
            isMovingRight = !isMovingRight; // Reverse direction
        }

        float directionX = isMovingRight ? 1f : -1f;
        transform.Translate(Vector2.right * directionX * speed * Time.deltaTime);
    }

    void Flip()
    {
        Vector3 localScale = transform.localScale;
        localScale.x *= -1f;
        transform.localScale = localScale;
    }
}
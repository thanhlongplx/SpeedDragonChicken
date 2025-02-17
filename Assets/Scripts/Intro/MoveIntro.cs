using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool MoveAlow = true;
    private float speed = 5;
    bool is_right = true;

    public float left_right;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move to right and left
        if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) && MoveAlow == true)
        {
            left_right = -1;
        }
        else if ((Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) && MoveAlow == true)
        {
            left_right = 1;
        }
        else
        {
            left_right = 0;
        }
        

        
        transform.Translate(Vector2.right * left_right * speed * Time.deltaTime);
        flip();
        // Animation set float de khoi dong

        
        



    }
    void flip()
    {// Hàm lật nhân vật gà long tốc độ
        if (is_right && left_right < 0 || !is_right && left_right > 0)
        {
            is_right = !is_right;
            Vector3 flipX = transform.localScale;
            flipX.x = flipX.x * (-1);
            transform.localScale = flipX;
            
        }
    }
}

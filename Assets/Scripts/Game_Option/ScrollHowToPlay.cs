using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;

public class ScrollHowToPlay : MonoBehaviour
{
    public int speed= 7;
    public int up_down;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)))
        {
            up_down = 1;
        }
        else if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)))
        {
            up_down = -1;
        }
        else{
            up_down = 0;
        }
        
        transform.Translate(Vector2.down * up_down * speed * Time.deltaTime);
    }
    

    
}

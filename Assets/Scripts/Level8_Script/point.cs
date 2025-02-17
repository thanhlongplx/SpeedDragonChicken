using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class point : MonoBehaviour
{
    public int point_lv8 =4;
    public int point_lv8_request = 3;
    public bool isTrue = true;
    public int false_time;
    public TextMeshProUGUI trueText;
    public TextMeshProUGUI falseText;
    void Start()
    {
        // point_lv8 =0;
        trueText.SetText(point_lv8.ToString());
        falseText.SetText(false_time.ToString());
    }
    void Update(){
        trueText.SetText(point_lv8.ToString());
        falseText.SetText(false_time.ToString());
    }

    
}

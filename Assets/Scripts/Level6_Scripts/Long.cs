using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Long : MonoBehaviour
{
    public GameObject LongGa;
    UIManager UI;
    
    
    void Start()
    {
        UI = FindObjectOfType<UIManager>();
        
    }

    // Update is called once per frame
    public void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Player")){
            if(UI.isHasKey){
                Destroy(LongGa);
            }
        }
    }
}

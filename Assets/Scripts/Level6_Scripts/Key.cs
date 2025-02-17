using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject key;
    public UIManager UI;

    public bool isHasKey =false;
    void Start()
    {
        UI= FindObjectOfType<UIManager>();
    }
    

    // Update is called once per frame
    public void OnTriggerEnter2D(Collider2D col){
        if(col.CompareTag("Player")){
            Destroy(key);
            UI.isHasKey = true;
            UI.showKeyPannel(true);
            UI.showPauseMenu= true;
            
            
        }
    }
}

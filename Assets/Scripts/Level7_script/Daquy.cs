using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daquy : MonoBehaviour
{
    public GameObject daquys;
    UIManager UI;
    TruAnhSang tru;
    
    void Start(){
        UI = FindObjectOfType<UIManager>();
        tru = FindObjectOfType<TruAnhSang>();
    }
    void OnTriggerEnter2D(Collider2D col){
        if(col.CompareTag("Player")){
            tru.daquyNumber++;
            Destroy(daquys);
            UI.showDaquyPannel(true);
            UI.showPauseMenu = true;

        }
    }
    
}

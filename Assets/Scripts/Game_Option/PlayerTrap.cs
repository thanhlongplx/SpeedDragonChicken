using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapPlayer : MonoBehaviour
{
    public GameObject TrapDisappears;


    public void OnTriggerEnter2D(Collider2D col){
        if(col.CompareTag("Player")){
            Destroy(TrapDisappears);
            
        }
    }
}

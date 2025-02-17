using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenChicken : MonoBehaviour
{
    public GameObject greenChicken;
    GateScript gate;

    void Start(){
        gate = FindObjectOfType<GateScript>();
    }
    void Update(){

    }
    

    public void OnTriggerEnter2D(Collider2D col){
        if(col.CompareTag("Player")){
            Destroy(greenChicken);
            
            gate.isGreenChicken= true;
        }
    }
}

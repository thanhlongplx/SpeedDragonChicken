using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GaCon : MonoBehaviour
{
    public int GaCon_Number=0;
    public bool fullGaCon = false;
    public int GaCon_Request=5;
    GateScript gateScript;
    void Start(){
        gateScript = FindObjectOfType<GateScript>();
       if((gateScript.scenceNumber-1) ==3){
            fullGaCon = false;
       }
       else{
        fullGaCon = true;
        GaCon_Number = GaCon_Request;
       }
    }
   
    
    
        
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book3Script : MonoBehaviour
{
    UIManager UI;
    MenuOption menu;
    public GameObject book3;
    void Start(){
        UI = FindObjectOfType<UIManager>();
        menu =FindObjectOfType<MenuOption>();
        }
    void OnTriggerEnter2D(Collider2D col){
        if(col.CompareTag("Player")){
            menu.showBook3Pannel();
            Destroy(book3);
        }
    }
}



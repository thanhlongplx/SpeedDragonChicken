using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book2Script : MonoBehaviour
{
    UIManager UI;
    MenuOption menu;
    public GameObject book2;
    void Start(){
        UI = FindObjectOfType<UIManager>();
        menu =FindObjectOfType<MenuOption>();
        }
    void OnTriggerEnter2D(Collider2D col){
        if(col.CompareTag("Player")){
            menu.showBook2Pannel();
            Destroy(book2);
        }
    }
}


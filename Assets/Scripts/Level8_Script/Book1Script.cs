using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookScript : MonoBehaviour
{
    UIManager UI;
    MenuOption menu;
    public GameObject book;
    void Start(){
        UI = FindObjectOfType<UIManager>();
        menu =FindObjectOfType<MenuOption>();
        }
    void OnTriggerEnter2D(Collider2D col){
        if(col.CompareTag("Player")){
            menu.showBook1Pannel();
            Destroy(book);
        }
    }
}

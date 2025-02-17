using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GateScript : MonoBehaviour
{
    public float X;
    public bool isGreenChicken= false;
    public int scenceNumber;
    Move move;
    GaCon Gacon;
    MenuOption MenuOption;
    public int PowerNumber = 0;
    public int PowerRequest;
    public bool isNextScene = true;
    void Start()
    {
        Gacon = FindObjectOfType<GaCon>();
        move = FindObjectOfType<Move>();
        MenuOption = FindObjectOfType<MenuOption>();
    }
    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player") && PowerNumber >= PowerRequest && Gacon.fullGaCon == true && isGreenChicken == true)
        {
            SceneManager.LoadScene(scenceNumber);
        }
        else if (col.CompareTag("Player") && (PowerNumber < PowerRequest || Gacon.fullGaCon == false || isGreenChicken == false))
        {
            MenuOption.showRequestMenu();
            col.transform.position = new Vector3(X, transform.position.y, transform.position.z);
        }
    }

}


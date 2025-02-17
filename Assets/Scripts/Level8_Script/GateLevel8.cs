using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GateLevel8 : MonoBehaviour
{

    public int scenceNumber;
    Menucontroller menu;

    

    point pt;


    void Start()
    {
        pt = FindObjectOfType<point>();
        menu = FindObjectOfType<Menucontroller>();
    }
    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player")  && pt.point_lv8 >= pt.point_lv8_request)
        {
            
            SceneManager.LoadScene(scenceNumber);
            
        }

    }

}


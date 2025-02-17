using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TruAnhSang : MonoBehaviour
{
    Daquy daquy;
    MenuOption menu;
    public TextMeshProUGUI sodaquy;
    public float X;
    public float X_whenOK;
    public float Y_whenOK;
    public GameObject Gate;
    public int daquyNumber = 0;
    public bool openGate = false;

    void Start()
    {
        daquy = FindObjectOfType<Daquy>();
        menu = FindObjectOfType<MenuOption>();
    }
    void Update(){
        sodaquy.SetText(daquyNumber.ToString());
        if(daquyNumber>3){
            daquyNumber =3;
        }
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            if (daquyNumber >= 3)
            {
                openGate = true;
                Gate.SetActive(openGate);
                menu.showKichHoatCongDichChuyenPannel();
                col.transform.position = new Vector3(X_whenOK, Y_whenOK, transform.position.z);

            }
            else
            {
                menu.showTruAnhSangRequestPannel();
                col.transform.position = new Vector3(X, transform.position.y, transform.position.z);
            }
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIVideo : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject GoiYPannel;
    public void showGoiYPannel(bool isShow){
        GoiYPannel.SetActive(isShow);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{


    public GameObject Gà_Long_Tốc_Độ;

    public bool is_GameOver;
    public int DemLanThua = 0;
    public int Respawns_text = 2;
    public int congLanThua = 1;


    public AudioSource aus;
    public AudioClip soundEarnSamSet;
    public AudioClip soundMissHeart;
    public AudioClip soundJump;

    GàLửa galua;
    public UIManager UI;

    void Start()
    {
        galua = FindObjectOfType<GàLửa>();
        UI = FindObjectOfType<UIManager>();

        UI.showPauseMenu = true;



    }

    // Update is called once per frame
    void Update()
    {






        if (is_GameOver)
        {
            UI.showGameoverPannel(true);
            UI.showPauseMenu = true;
            UI.ShowPauseButton(false);
            DemLanThua += congLanThua;
            congLanThua = 0;
        }

        if (DemLanThua < 3 && galua.solanCham > 0)
        {
            UI.ShowContinue(true);
        }
        else
        {
            UI.ShowContinue(false);
        }






    }
    // tạo sét cho Menu

    public void SetGameOverState(bool state)// Kiểm tra game có over hay không
    {
        is_GameOver = state;
        UI.UpdateRespawnText(Respawns_text);
    }




}

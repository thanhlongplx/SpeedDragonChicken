using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;
using UnityEngine.InputSystem;


public class Move : MonoBehaviour
{

    GameController gameController;
    UIManager UI;
    GateScript GateScript;
    GaCon GaCon;

    GàLửa galua;


    public TextMeshProUGUI NhacNhoRQ;
    public TextMeshProUGUI NhacNhoRQ_Eng;
    public TextMeshProUGUI MangSongText;
    public TextMeshProUGUI NangLuongText_top_right;
    public bool MoveAlow = true;
    private float speed = 10;
    private int NangLuongPresent;
    public int heart = 3;
    private int NangLuong = 0;
    private bool is_right = true;
    private bool Jump_alow;
    public bool fullGaCon;

    public int high;
    public float left_right;
    private Rigidbody2D rb;
    private Animator anim;
    public GameObject Player;
    public GamepadSpeakerOutputType outputType;




    public float[] playerPosition;

    void Start()
    {
        galua = FindObjectOfType<GàLửa>();
        GaCon = FindObjectOfType<GaCon>();
        GateScript = FindObjectOfType<GateScript>();
        UI = FindObjectOfType<UIManager>();
        gameController = FindObjectOfType<GameController>();

        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        NangLuongText_top_right.SetText(NangLuong.ToString());
        MangSongText.SetText(heart.ToString());
        NhacNhoRQ.SetText(GateScript.PowerRequest.ToString());
        NhacNhoRQ_Eng.SetText(GateScript.PowerRequest.ToString());
        GateScript.PowerNumber = 0;


    }

    // Update is called once per frame
    void Update()
    {
        MangSongText.SetText(heart.ToString());
        //cap nhat game over
        is_GameOver();
        if (gameController.is_GameOver)
        {
            UI.ShowPauseButton(false);
        }









        // Di chuyen
        // left_right= Input.GetAxis("Horizontal");
        // rb.velocity = new Vector2(left_right*speed, rb.velocity.y);
        // //gọi hàm để lật tọa độ X
        // flip();
        // anim.SetFloat("Move", Mathf.Abs(left_right));




        if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) || (Gamepad.current != null && Gamepad.current.leftStick.x.ReadValue() < 0f)) && !gameController.is_GameOver && MoveAlow)
        {
            Debug.Log(Gamepad.current.leftStick.x.ReadValue());
            left_right = -1;
        }
        else if ((Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) || (Gamepad.current != null && Gamepad.current.leftStick.x.ReadValue() > 0f)) && !gameController.is_GameOver && MoveAlow)
        {
            Debug.Log(Gamepad.current.leftStick.x.ReadValue());
            left_right = 1;
        }
        else
        {
            left_right = 0;
        }

        transform.Translate(Vector2.right * left_right * speed * Time.deltaTime);
        flip();
        if (((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Space) || Gamepad.current.buttonNorth.wasPressedThisFrame) && Jump_alow == true) && (gameController.is_GameOver == false) && (!UI.showPauseMenu))
        {
            // transform.Translate(Vector2.up*high); jump
            rb.AddForce(Vector2.up * high, ForceMode2D.Impulse);
            gameController.aus.PlayOneShot(gameController.soundJump);
        }

        //Kiểm tra xem có hiện pause menu không
        //nếu có, ngăn ko cho di chuyển
        if (UI.showPauseMenu)
        {
            MoveAlow = false;
            gameObject.GetComponent<Rigidbody2D>().simulated = false;

        }
        else
        {
            gameObject.GetComponent<Rigidbody2D>().simulated = true;
            MoveAlow = true;
        }


        if (!GaCon.fullGaCon)
        {
            if (GaCon.GaCon_Number == GaCon.GaCon_Request)
            {
                fullGaCon = true;
            }
        }


    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            Jump_alow = true;
        }
        if (col.gameObject.tag == "GaiNhon" || col.gameObject.tag == "GaHacAm" || col.gameObject.tag == "GaBeoBu")
        {
            heart--;

            if (heart <= 0)
            {
                heart = 0;
            }
            MangSongText.SetText(heart.ToString());
            if (gameController.aus && gameController.soundMissHeart)
            {
                gameController.aus.PlayOneShot(gameController.soundMissHeart);
            }

        }
        if (col.gameObject.tag == "Sấm sét")
        {
            NangLuong++;
            NangLuongPresent = NangLuong;
            GateScript.PowerNumber = NangLuongPresent;
            NangLuong = NangLuongPresent;
            NangLuongText_top_right.SetText(NangLuong.ToString());
            if (gameController.aus && gameController.soundEarnSamSet)
            {
                gameController.aus.PlayOneShot(gameController.soundEarnSamSet);
            }
            playerPosition = new float[] { Player.transform.position.x, Player.transform.position.y, Player.transform.position.z };
            Destroy(col.gameObject);
        }
        else if (NangLuong == 0)
        {
            playerPosition = new float[] { 0, 0, 0 };
        }
        if (col.gameObject.tag == "MangSong")
        {
            heart++;

            Destroy(col.gameObject);
            MangSongText.SetText(heart.ToString());
        }
        if (col.gameObject.tag == "OverSquare")
        {
            gameController.SetGameOverState(true);
            // playerPosition = new float[] { 0, 0, 0 };
        }
        if (col.gameObject.tag == "GaCon")
        {
            GaCon.GaCon_Number++;
            Destroy(col.gameObject);
        }
        if (GaCon.GaCon_Number == GaCon.GaCon_Request)
        {
            GaCon.fullGaCon = true;
        }
        if (col.gameObject.tag == "GaLua")
        {
            NangLuong--;
            if (NangLuong <= 0)
            {
                NangLuong = 0;
            }
            NangLuongPresent = NangLuong;
            heart--;
            galua.giamlanCham--;
            NangLuongText_top_right.SetText(NangLuong.ToString());
            MangSongText.SetText(heart.ToString());
            if (heart == 0 || galua.giamlanCham == 0)
            {
                UI.showPauseMenu = true;
                galua.directionX = 0;
            }
            if (galua.giamlanCham == 0)
            {
                UI.ShowContinue(false);
            }
        }

    }
    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            Jump_alow = false;
        }
        if (col.gameObject.tag == "GaHacAm")
        {
            Jump_alow = true;
        }

    }

    void flip()
    {// Hàm lật nhân vật gà long tốc độ
        if (is_right && left_right < 0 || !is_right && left_right > 0)
        {
            is_right = !is_right;
            Vector3 flipX = transform.localScale;
            flipX.x = flipX.x * (-1);
            transform.localScale = flipX;
        }
    }
    void is_GameOver()
    {
        if (heart <= 0)
        {
            gameController.SetGameOverState(true);
            MoveAlow = false;

        }
    }
    public void continues()
    {
        gameController.is_GameOver = false;
        NangLuong = NangLuongPresent;
        heart = 3;
        Jump_alow = true;
        MoveAlow = true;
        gameController.congLanThua = 1;
        UI.showGameoverPannel(false);
        UI.showthongBaoGaLua(false);
        NangLuongText_top_right.SetText(NangLuong.ToString());
        MangSongText.SetText(heart.ToString());
        transform.position = new Vector3(playerPosition[0], playerPosition[1] + 3, playerPosition[2]);
        UI.ShowPauseButton(true);
        UI.showthongBaoGaLua(false);
        gameController.Respawns_text--;
        UI.showPauseMenu = false;
        galua.directionX = galua.temp;

    }




}

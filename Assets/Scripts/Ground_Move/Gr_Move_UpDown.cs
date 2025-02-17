using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gr_Move_UpDown : MonoBehaviour
{
    public float speed = 3;
    private float updown;
    private float current_Y;
    private float po_Y;
    private float tamp;
    public float po_Y_Move = 5;
    private UIManager UI;
    public GameObject groundMove;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        UI = FindObjectOfType<UIManager>();
        po_Y = transform.position.y;
        tamp = po_Y;
        updown = -1;

    }

    // Update is called once per frame
    void Update()
    {
        if (!UI.showPauseMenu)
        {
            if (groundMove.transform.position.y >= tamp + po_Y_Move)
            {
                updown = -1;
                current_Y = updown * speed * Time.deltaTime;
            }
            if (groundMove.transform.position.y <= tamp - po_Y_Move)
            {
                updown = 1;
                current_Y = updown * speed * Time.deltaTime;
            }
            transform.Translate(Vector2.up * updown * speed * Time.deltaTime);
        }
    }
}

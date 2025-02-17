using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GR_Move_LR : MonoBehaviour
{
    public float speed = 3;
    private float left_right;
    private float current_X;
    private float po_X;
    private float tamp;
    public float po_X_Move = 5;
    public GameObject groundMove;
    private Rigidbody2D rb;
    private UIManager UI;
    // Start is called before the first frame update
    void Start()
    {
        UI = FindObjectOfType<UIManager>();
        po_X = transform.position.x;
        tamp = po_X;
        left_right = -1;

    }

    // Update is called once per frame
    void Update()
    {
        if (!UI.showPauseMenu)
        {
            if (groundMove.transform.position.x >= tamp + po_X_Move)
            {
                left_right = -1;
                current_X = left_right * speed * Time.deltaTime;
            }
            if (groundMove.transform.position.x <= tamp - po_X_Move)
            {
                left_right = 1;
                current_X = left_right * speed * Time.deltaTime;
            }
            transform.Translate(Vector2.right * left_right * speed * Time.deltaTime);
        }
    }
}

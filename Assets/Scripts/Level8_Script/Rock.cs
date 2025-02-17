using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Rock : MonoBehaviour
{
    private Animator anim;
    public GameObject rockk;
    private point pt; // Thay đổi kiểu biến thành private

    void Start()
    {
        anim = GetComponent<Animator>(); // Khởi tạo Animator
        pt = FindObjectOfType<point>(); // Tìm đối tượng point
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            if (pt.point_lv8 >= pt.point_lv8_request)
            {

                anim.SetBool("isCrack", true); // Kích hoạt animation
                StartCoroutine(DestroyRockAfterDelay(2f)); // Bắt đầu coroutine để hủy sau 2 giây
            }
        }
    }

    IEnumerator DestroyRockAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay); // Đợi trong 2 giây
        Destroy(rockk); // Hủy đối tượng rockk
    }


}
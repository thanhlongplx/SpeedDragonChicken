using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomLocation : MonoBehaviour
{
    
    // Đối tượng Book
    public GameObject Book;
    public float vitri1X;
    public float vitri1Y;
    public float vitri2X;
    public float vitri2Y;
    public float vitri3X;
    public float vitri3Y;

    // Mảng đa chiều chứa tọa độ
    private Vector2[,] positions = new Vector2[3, 1];

    void Start()
    {
        // Khởi tạo tọa độ
        positions[0, 0] = new Vector2(vitri1X, vitri1Y);
        positions[1, 0] = new Vector2(vitri2X, vitri2Y);
        positions[2, 0] = new Vector2(vitri3X, vitri3Y);

        // Random chọn một tọa độ
        int randomIndex = Random.Range(0, positions.GetLength(0));
        Vector2 randomPosition = positions[randomIndex, 0];

        // Đặt vị trí cho đối tượng A
        Book.transform.position = randomPosition;
    }
}

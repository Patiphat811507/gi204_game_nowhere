using UnityEngine;

public class ExitGame : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X)) // ถ้ากดปุ่ม X
        {
            Application.Quit(); // ปิดเกม
            Debug.Log("Game Closed!"); // แสดงข้อความใน Console (สำหรับเช็คใน Unity Editor)
        }
    }
}

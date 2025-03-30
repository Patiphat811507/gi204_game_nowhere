using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartOnKeyPress : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) // ตรวจจับการกดปุ่ม R
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); // รีสตาร์ทฉาก
        }
    }
}
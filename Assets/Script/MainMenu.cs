using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenuPanel; // อ้างอิง Panel เมนูหลัก
    public Button startButton;
    public Button quitButton;

    void Start()
    {
        // ตรวจสอบว่ามีการเชื่อมต่อปุ่ม
        if (startButton != null)
            startButton.onClick.AddListener(StartGame);

        if (quitButton != null)
            quitButton.onClick.AddListener(QuitGame);
    }

    void Update()
    {
        // ตรวจสอบว่ากดปุ่ม Enter (Return) หรือยัง
        if (Input.GetKeyDown(KeyCode.Return))
        {
            StartGame();
        }
    }

    void StartGame()
    {
        if (mainMenuPanel != null)
        {
            mainMenuPanel.SetActive(false); // ซ่อนเมนู
            Debug.Log("Game Started!");
        }
    }

    void QuitGame()
    {
        Debug.Log("Quit Game!");
        Application.Quit(); // ใช้ได้เมื่อรันเป็นไฟล์ .exe หรือ .apk
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportOnCollision : MonoBehaviour
{
    public string sceneToLoad; // กำหนดชื่อ Scene ที่ต้องการวาร์ปไป

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // ตรวจสอบว่าเป็น Player หรือไม่
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}


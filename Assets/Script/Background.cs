using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    private static BackgroundMusic instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // ทำให้เพลงเล่นต่อเนื่องทุกฉาก
        }
        else
        {
            Destroy(gameObject);
        }
    }
}


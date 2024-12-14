
using UnityEngine;
using UnityEngine.SceneManagement; // Library untuk manajemen scene

public class main_menu : MonoBehaviour
{
    private bool isExiting = false; // Untuk mencegah multiple execution

    // Method untuk berpindah ke scene "Mulai"
    public void LoadMulaiScene()
    {
        SceneManager.LoadScene("Mulai");
    }

    // Method untuk berpindah ke scene "Tentang"
    public void LoadTentangScene()
    {
        SceneManager.LoadScene("Tentang");
    }
     // Method untuk berpindah ke scene "profile"
    public void LoadProfileScene()
    {
        SceneManager.LoadScene("profile");
    }

    // Method untuk berpindah ke scene "Keluar" terlebih dahulu
    public void GoToExitScene()
    {
        if (!isExiting)
        {
            isExiting = true; // Tandai proses keluar sedang berlangsung
            SceneManager.LoadScene("Keluar");
            Invoke("QuitApplication", 2.0f); // Tunggu 2 detik sebelum keluar aplikasi
        }
    }

    // Method untuk keluar dari aplikasi
    private void QuitApplication()
    {
        Application.Quit();
        Debug.Log("Aplikasi keluar"); // Hanya terlihat di edito
    }
}

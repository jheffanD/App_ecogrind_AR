using UnityEngine;
using UnityEngine.SceneManagement; // Library untuk manajemen scene

public class Kembali : MonoBehaviour
{
    // Method untuk kembali ke halaman "SampleScene"
    public void LoadSampleScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}

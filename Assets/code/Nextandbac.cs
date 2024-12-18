using UnityEngine;
using UnityEngine.SceneManagement; // Library untuk manajemen scene

public class Nextandbac : MonoBehaviour
{

    // Method untuk kembali ke halaman "SampleScene"
    public void NextProfile2()
    {
        SceneManager.LoadScene("Profile2");
    }
   
    public void BackProfile1()
    {
        SceneManager.LoadScene("SampleScene");
    }
   
}



using UnityEngine;
using UnityEngine.SceneManagement; // Library untuk manajemen scene

public class profile2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   public void Next()
    {
       SceneManager.LoadScene("Profile3");  
    }

    // Update is called once per frame
   public void Back()
    {
  
        SceneManager.LoadScene("Profile");
    
    }
}

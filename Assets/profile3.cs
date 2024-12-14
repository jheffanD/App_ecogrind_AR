using UnityEngine;
using UnityEngine.SceneManagement; // Library untuk manajemen scene

public class profile3 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
  public void Back()
    {
       SceneManager.LoadScene("Profile2");  
    }

    // Update is called once per frame
 public  void Next()
    {
        SceneManager.LoadScene("SampleScene");
    }
}

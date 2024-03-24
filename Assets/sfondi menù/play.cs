using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class play : MonoBehaviour
{
    public void LoadNextScene()
    {
        SceneManager.LoadScene("test");
    }
    
}

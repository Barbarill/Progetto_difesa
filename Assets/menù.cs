using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menù : MonoBehaviour
{
    public void play()
    {
        SceneManager.LoadScene(0);
        print("ciao");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Snowground")
        {
            Debug.Log("Oh no you crashed!!");
            Invoke("ReloadScene", 0.5f);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}

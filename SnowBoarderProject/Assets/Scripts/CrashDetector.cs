using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashClip;
    bool alreadyCrashed = false;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Snowground")
        {
            FindObjectOfType<PlayerController>().disableControls();
            Debug.Log("Oh no you crashed!!");
            crashEffect.Play();
            if (!alreadyCrashed)
            {
                GetComponent<AudioSource>().PlayOneShot(crashClip);
            }
            alreadyCrashed = true;
            Invoke("ReloadScene", 0.8f);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}

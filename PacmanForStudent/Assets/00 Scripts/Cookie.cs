using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cookie : MonoBehaviour
{
    public AudioSource pickSfx;
    public StageManager stageManager;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Pacman")
        {
            pickSfx.Play();
            stageManager.OnCookieEaten();
            Destroy(gameObject);
        }
    }
}

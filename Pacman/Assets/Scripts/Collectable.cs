using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public AudioSource pickSound;
    public StageManager stageManager;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Pacman")
        {
            Debug.Log("통과 확인");
            stageManager.OnCookieEaten();
            pickSound.Play();
            Destroy(gameObject);
        }
    }
}

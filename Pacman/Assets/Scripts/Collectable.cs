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
            Debug.Log("��� Ȯ��");
            stageManager.OnCookieEaten();
            pickSound.Play();
            Destroy(gameObject);
        }
    }
}

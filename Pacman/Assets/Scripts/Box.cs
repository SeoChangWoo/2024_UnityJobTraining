using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public Animator boxAnimator;
    public GameObject quizPanel;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Pacman")
        {
            boxAnimator.Play("Open");
            Time.timeScale = 0;
            quizPanel.SetActive(true);
        }
    }
}

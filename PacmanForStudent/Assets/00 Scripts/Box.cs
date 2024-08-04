using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public Animator boxAnimator;
    public GameObject itemPanel;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Pacman")
        {
            boxAnimator.Play("Open");
            itemPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
    public void ContinueStage()
    {
        Time.timeScale = 1;
        itemPanel.SetActive(false);
        gameObject.SetActive(false);
    }
}

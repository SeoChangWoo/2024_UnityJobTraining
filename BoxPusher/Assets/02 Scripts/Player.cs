using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform playerTransform;
    public float speed;
    public Animator playerAnimator;

    void Start()
    {
        
    }
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            playerTransform.position = playerTransform.position + Vector3.forward * Time.deltaTime * speed;
            playerTransform.LookAt(playerTransform.position + Vector3.forward);
            playerAnimator.Play("run");
        }
        if (Input.GetKey(KeyCode.A))
        {
            playerTransform.position = playerTransform.position + Vector3.left * Time.deltaTime * speed;
            playerTransform.LookAt(playerTransform.position + Vector3.left);
            playerAnimator.Play("run");
        }
        if (Input.GetKey(KeyCode.S))
        {
            playerTransform.position = playerTransform.position + Vector3.back * Time.deltaTime * speed;
            playerTransform.LookAt(playerTransform.position + Vector3.back);
            playerAnimator.Play("run");
        }
        if (Input.GetKey(KeyCode.D))
        {
            playerTransform.position = playerTransform.position + Vector3.right * Time.deltaTime * speed;
            playerTransform.LookAt(playerTransform.position + Vector3.right);
            playerAnimator.Play("run");
        }
        if(Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D))
        {
            playerAnimator.Play("idle");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform playerTransform;
    public float speed;
    void Update()
    {
        PlayerInput();
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    private void PlayerInput()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            playerTransform.Rotate(0, 90, 0);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            playerTransform.Rotate(0, -90, 0);
        }
    }
    public void RotateRight()
    {
        playerTransform.Rotate(0, 90, 0);
    }
    public void RotateLeft()
    {
        playerTransform.Rotate(0, -90, 0);
    }
}

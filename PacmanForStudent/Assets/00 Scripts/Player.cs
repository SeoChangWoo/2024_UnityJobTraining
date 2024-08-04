using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform playerTransform;
    public float speed;
    void Update()
    {
        PlayerMove();
        playerTransform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
    /// <summary>
    /// ����Ű�� ���� �Ѹ��� ȸ���ϴ� �޼���
    /// </summary>
    private void PlayerMove()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            playerTransform.Rotate(0, -90, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            playerTransform.Rotate(0, 90, 0);
        }
    }
    public void RotateLeft()
    {
        playerTransform.Rotate(0, -90, 0);
    }
    public void RotateRight()
    {
        playerTransform.Rotate(0, 90, 0);
    }

    public void GetSpeedItem(float value)
    {
        speed = speed * value;
    }
}

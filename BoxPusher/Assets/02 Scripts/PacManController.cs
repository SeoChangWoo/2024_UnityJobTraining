using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacManController : MonoBehaviour
{
    public float speed = 5.0f;
    public float rotationSpeed = 200.0f;

    void Update()
    {
        // ����Ű �Է¿� ���� �Ѹ��� ȸ���� �����մϴ�.
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.rotation = Quaternion.Euler(0, -90, 0); // ���� ����
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.rotation = Quaternion.Euler(0, 90, 0); // ������ ����
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.rotation = Quaternion.Euler(0, 0, 0); // ���� ����
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.rotation = Quaternion.Euler(0, 180, 0); // �Ʒ��� ����
        }

        // �Ѹ��� �׻� �ٶ󺸴� �������� �̵��մϴ�.
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Food"))
        {
            // ���̸� �Ծ��� ���� ����
            Destroy(other.gameObject);
            // ���� �ý��� ȣ�� (����)
            // QuizManager.Instance.ShowQuiz();
        }
    }
}

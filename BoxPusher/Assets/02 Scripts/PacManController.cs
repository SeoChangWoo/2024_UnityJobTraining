using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacManController : MonoBehaviour
{
    public float speed = 5.0f;
    public float rotationSpeed = 200.0f;

    void Update()
    {
        // 방향키 입력에 따라 팩맨의 회전을 조정합니다.
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.rotation = Quaternion.Euler(0, -90, 0); // 왼쪽 방향
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.rotation = Quaternion.Euler(0, 90, 0); // 오른쪽 방향
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.rotation = Quaternion.Euler(0, 0, 0); // 위쪽 방향
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.rotation = Quaternion.Euler(0, 180, 0); // 아래쪽 방향
        }

        // 팩맨은 항상 바라보는 방향으로 이동합니다.
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Food"))
        {
            // 먹이를 먹었을 때의 동작
            Destroy(other.gameObject);
            // 퀴즈 시스템 호출 (예시)
            // QuizManager.Instance.ShowQuiz();
        }
    }
}

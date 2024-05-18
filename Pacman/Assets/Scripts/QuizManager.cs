using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour
{
    public int correctAnswerIndex;
    public GameObject box;
    public void CheckAnswerIsCorrect(int answerIndex)
    {
        if (correctAnswerIndex == answerIndex)
        {
            Debug.Log("정답입니다.");
            Time.timeScale = 1;
            gameObject.SetActive(false);
            box.SetActive(false);
        }
        else
        {
            Debug.Log("오답입니다.");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Time.timeScale = 1;
        }
    }
}

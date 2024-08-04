using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StageManager : MonoBehaviour
{
    public int totalCookieCount;
    public int eatenCookieCount;

    public Text totalCookieCountObject;
    public Text eatenCookieCountObject;
    void Start()
    {
        totalCookieCount = GameObject.FindGameObjectsWithTag("Cookie").Length;
        eatenCookieCount = 0;

        totalCookieCountObject.text = totalCookieCount.ToString();
        eatenCookieCountObject.text = eatenCookieCount.ToString();
    }
    public void OnCookieEaten()
    {
        eatenCookieCount++;
        eatenCookieCountObject.text = eatenCookieCount.ToString();
        if(eatenCookieCount == totalCookieCount)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}

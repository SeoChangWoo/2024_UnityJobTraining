using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StageManager : MonoBehaviour
{
    public int totalCookies;
    public int eatenCookie;

    public Text currentCookies;
    public Text goalCookies;
    void Start()
    {
        totalCookies = GameObject.FindGameObjectsWithTag("Cookie").Length;
        goalCookies.text = totalCookies.ToString();
        eatenCookie = 0;
        currentCookies.text = eatenCookie.ToString();
    }
    public void OnCookieEaten()
    {
        eatenCookie++;
        currentCookies.text = eatenCookie.ToString();
        Debug.Log(eatenCookie);
        CheckAndLoadNextStage();
    }

    public void CheckAndLoadNextStage()
    {
        if(eatenCookie >= totalCookies)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}

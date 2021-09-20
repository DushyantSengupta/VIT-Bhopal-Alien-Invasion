using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using UnityEngine.SceneManagement;
public class Countdown : MonoBehaviour
{
    public int timeLeft = 180; 
    public Text countdown; 
    void Start()
    {
        StartCoroutine("LoseTime");
        Time.timeScale = 1; 
    }
    void Update()
    {
        countdown.text = ("" + timeLeft);
        if(timeLeft==0)
        {
            SceneManager.LoadScene("Out of Time");
        }
    }
    //Simple Coroutine
    IEnumerator LoseTime()
    {
        if(timeLeft==0)
        {
            SceneManager.LoadScene("Out of Time");
        }
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
            if (timeLeft == 0)
            {
                SceneManager.LoadScene("Out of Time");
            }
        }
    }
}
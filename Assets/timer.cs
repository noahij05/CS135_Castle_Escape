using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class timer : MonoBehaviour
{
    public Text timerText;
    public Text bestTime;
    private float startTime;
    bool gameStart = false;
    string endtime;
    float min, bestMin;
    float sec, bestSec;
    

    // Start is called before the first frame update
    void Start()
    {
        
        bestTime.text = PlayerPrefs.GetString("Best Time", "No Best Time Yet");
        bestMin = PlayerPrefs.GetFloat("Best Min", 1000000.0f);
        bestSec = PlayerPrefs.GetFloat("Best Sec", 1000000.0f);
    }

    // Update is called once per frame
    void Update()
    {
        /*if(Input.GetKeyDown("0"))
        {
            PlayerPrefs.DeleteAll();

            #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
            #else
            Application.Quit();
            #endif
        }*/

        if (gameStart)
        {
            float t = Time.time - startTime;

            string minutes = ((int)t / 60).ToString();
            string seconds = (t % 60).ToString("f2");

            min = ((int)t / 60);
            sec = (t % 60);

            timerText.text = minutes + ":" + seconds;

            if (Input.GetKeyDown("2"))
            {
                gameStart = false;
            }
        }
        else
        {
            if (Input.GetKeyDown("1"))
            {
                gameStart = true;
                startTime = Time.time;
            }
        }
    }

    private void OnApplicationQuit()
    {
        /*if (min > bestMin)
        {
           
        }
        else if (min == bestMin)
        {
            if(sec <= bestSec)
            {
                endtime = timerText.text;
                PlayerPrefs.SetString("Best Time", endtime);
                PlayerPrefs.SetFloat("Best Min", min);
                PlayerPrefs.SetFloat("Best Sec", sec);
            }
        }
        else if (min < bestMin)
        {*/
            endtime = timerText.text;
            PlayerPrefs.SetString("Best Time", endtime);
            PlayerPrefs.SetFloat("Best Min", min);
            PlayerPrefs.SetFloat("Best Sec", sec);
       //}
        
    }
}

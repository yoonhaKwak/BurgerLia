using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer2 : MonoBehaviour
{
    public float time;
    public float msec;
    public float sec;
    public Text timerText;
    // Start is called before the first frame update
    void Start()
    {
        time = 50;
        StartCoroutine("StopWatch");
    }
    IEnumerator StopWatch()
    {
        while (true)
        {
            time -= Time.deltaTime;
            msec = (int)((time - (int)time) * 100);
            sec = (int)(time % 60);

            timerText.text = string.Format("{0:00}:{1:00}", sec, msec);
            yield return null;

            if (time <= 0.010)
            {
                StopCoroutine("StopWatch");
                SceneManager.LoadScene("GameoverScene2");
            }
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameoverButtonController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RetryClickListener()
    {
        SceneManager.LoadScene("GameScene1");
    }
    public void Retry_ClickListener()
    {
        SceneManager.LoadScene("GameScene2");
    }
    public void Retry__ClickListener()
    {
        SceneManager.LoadScene("GameScene3");
    }
    public void ExitClickListener()
    {
        SceneManager.LoadScene("FirstScene");
    }
}

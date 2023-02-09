using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clear2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void NextLevelClickListener()
    {
        SceneManager.LoadScene("GameScene3");
    }
    public void ExitClickListener()
    {
        SceneManager.LoadScene("FirstScene");
    }
}

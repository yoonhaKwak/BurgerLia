using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ButtonController : MonoBehaviour
{
    GameObject topBun;
    GameObject egg;
    GameObject tomato;
    GameObject meat;
    GameObject bottomBun;
    sampleController sampleController;
    public int score = 0;
    public int endScore = 8;
    public Text scoreText;
    public AudioClip scoreSound;
    AudioSource aud;
    void Start()
    {
        this.topBun = GameObject.Find("topBun");
        this.egg = GameObject.Find("egg");
        this.tomato = GameObject.Find("tomato");
        this.meat = GameObject.Find("meat");
        this.bottomBun = GameObject.Find("bottomBun");
        this.sampleController = GameObject.Find("topBun_s").GetComponent<sampleController>();
        this.aud = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void topBunButtonDown()
    {
        transform.Translate(-8, 0, 0);
    }
    public void eggButtonDown()
    {
        transform.Translate(-12, 0, 0);
    }
    public void tomatoButtonDown()
    {
        transform.Translate(-16, 0, 0);
    }
    public void meatButtonDown()
    {
        transform.Translate(-20, 0, 0);
    }
    public void bottomBunButtonDown()
    {
        transform.Translate(-24, 0, 0);
    }
    public void clearButtonDown()
    {
        topBun.transform.position = new Vector3(12,2,0);
        egg.transform.position = new Vector3(16, 2, 0);
        tomato.transform.position = new Vector3(20, 2, 0);
        meat.transform.position = new Vector3(24, 2, 0);
        bottomBun.transform.position = new Vector3(28, 2, 0);

    }
    public void EnterButtonDown()
    {
       if(sampleController.random == 0)
        {
            if((int)((topBun.transform.position.y)*100) >= -2 &
                (int)((egg.transform.position.y) * 100) >= -50 &
                (int)((egg.transform.position.y) * 100) <= -30 &
                (int)((tomato.transform.position.y) * 100) <= -70 &
                (int)((tomato.transform.position.y) * 100) >= -90 &
                (int)((meat.transform.position.y) * 100) <= -100 &
                (int)((meat.transform.position.y) * 100) >= -120 &
                (int)((bottomBun.transform.position.y) * 100) <= -170)
            {
                score += 1;
                this.aud.PlayOneShot(this.scoreSound);
                scoreText.text = string.Format("Score : {0}/{1}", score, endScore);

                sampleController.topBun_s.transform.position = new Vector3(-30, 2, 0);
                sampleController.egg_s.transform.position = new Vector3(-26, 2, 0);
                sampleController.tomato_s.transform.position = new Vector3(-22, 2, 0);
                sampleController.meat_s.transform.position = new Vector3(-18, 2, 0);
                sampleController.bottomBun_s.transform.position = new Vector3(-14, 2, 0);

                sampleController.sampleBurger();
               
                topBun.transform.position = new Vector3(12, 2, 0);
                egg.transform.position = new Vector3(16, 2, 0);
                tomato.transform.position = new Vector3(20, 2, 0);
                meat.transform.position = new Vector3(24, 2, 0);
                bottomBun.transform.position = new Vector3(28, 2, 0);
            }

        }
        if (sampleController.random == 1)
        {
            if ((int)((topBun.transform.position.y) * 100) >= -2 &
                (int)((egg.transform.position.y) * 100) >= -120 &
                (int)((egg.transform.position.y) * 100) <= -95 &
                (int)((tomato.transform.position.y) * 100) <= -120 &
                (int)((tomato.transform.position.y) * 100) >= -150 &
                (int)((meat.transform.position.y) * 100) <= -30 &
                (int)((meat.transform.position.y) * 100) >= -60 &
                (int)((bottomBun.transform.position.y) * 100) <= -170)
            {
                score += 1;
                this.aud.PlayOneShot(this.scoreSound);
                scoreText.text = string.Format("Score : {0}/{1}", score, endScore);

                sampleController.topBun_s.transform.position = new Vector3(-30, 2, 0);
                sampleController.egg_s.transform.position = new Vector3(-26, 2, 0);
                sampleController.tomato_s.transform.position = new Vector3(-22, 2, 0);
                sampleController.meat_s.transform.position = new Vector3(-18, 2, 0);
                sampleController.bottomBun_s.transform.position = new Vector3(-14, 2, 0);

                sampleController.sampleBurger();

                topBun.transform.position = new Vector3(12, 2, 0);
                egg.transform.position = new Vector3(16, 2, 0);
                tomato.transform.position = new Vector3(20, 2, 0);
                meat.transform.position = new Vector3(24, 2, 0);
                bottomBun.transform.position = new Vector3(28, 2, 0);
            }

        }
        if (sampleController.random == 2)
        {
            if ((int)((topBun.transform.position.y) * 100) >= -2 &
                (int)((egg.transform.position.y) * 100) >= -150 &
                (int)((egg.transform.position.y) * 100) <= -120 &
                (int)((tomato.transform.position.y) * 100) <= -40 &
                (int)((tomato.transform.position.y) * 100) >= -60 &
                (int)((meat.transform.position.y) * 100) <= -70 &
                (int)((meat.transform.position.y) * 100) >= -90 &
                (int)((bottomBun.transform.position.y) * 100) <= -170)
            {
                score += 1;
                this.aud.PlayOneShot(this.scoreSound);
                scoreText.text = string.Format("Score : {0}/{1}", score, endScore);

                sampleController.topBun_s.transform.position = new Vector3(-30, 0.5f, 0);
                sampleController.egg_s.transform.position = new Vector3(-26, 0.5f, 0);
                sampleController.tomato_s.transform.position = new Vector3(-22, 0.5f, 0);
                sampleController.meat_s.transform.position = new Vector3(-18, 0.5f, 0);
                sampleController.bottomBun_s.transform.position = new Vector3(-14, 0.5f, 0);

                sampleController.sampleBurger();

                topBun.transform.position = new Vector3(12, 2, 0);
                egg.transform.position = new Vector3(16, 2, 0);
                tomato.transform.position = new Vector3(20, 2, 0);
                meat.transform.position = new Vector3(24, 2, 0);
                bottomBun.transform.position = new Vector3(28, 2, 0);
            }

        }


        if (score == 8)
        {
            SceneManager.LoadScene("ClearScene");
        }
            
    }
}

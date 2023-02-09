using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonController_3 : MonoBehaviour
{
    GameObject topBun;
    GameObject ketchup;
    GameObject onion;
    GameObject cheese;
    GameObject paprika;
    GameObject meat;
    GameObject cucumber;
    GameObject salad;
    GameObject bottomBun;
    sampleController3 sampleController;
    public int score = 0;
    public int endScore = 8;
    public Text scoreText;
    public AudioClip scoreSound;
    AudioSource aud;
    // Start is called before the first frame update
    void Start()
    {
        this.topBun = GameObject.Find("topBun");
        this.ketchup = GameObject.Find("ketchup");
        this.onion = GameObject.Find("onion");
        this.cheese = GameObject.Find("cheese");
        this.paprika = GameObject.Find("paprika");
        this.meat = GameObject.Find("meat");
        this.cucumber = GameObject.Find("cucumber");
        this.salad = GameObject.Find("salad");
        this.bottomBun = GameObject.Find("bottomBun");
        this.sampleController = GameObject.Find("topBun_s").GetComponent<sampleController3>();
        this.aud = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void topBunButtonDown()
    {
        transform.Translate(-9, 1, 0);
    }
    public void ketchupButtonDown()
    {
        transform.Translate(-12.5f, 0, 0);
    }
    public void onionButtonDown()
    {
        transform.Translate(-16, 0, 0);
    }
    public void cheeseButtonDown()
    {
        transform.Translate(-19.5f, 0, 0);
    }
    public void paprikaButtonDown()
    {
        transform.Translate(-23, 0, 0);
    }
    public void meatButtonDown()
    {
        transform.Translate(-26.5f, 0, 0);
    }
    public void cucumberButtonDown()
    {
        transform.Translate(-30, 0, 0);
    }
    public void saladButtonDown()
    {
        transform.Translate(-33.5f, 0, 0);
    }
    public void bottomBunButtonDown()
    {
        transform.Translate(-37, 0, 0);
    }
    public void clearButtonDown()
    {
        topBun.transform.position = new Vector3(13, 2, 0);
        ketchup.transform.position = new Vector3(16.5f, 2, 0);
        onion.transform.position = new Vector3(20, 2, 0);
        cheese.transform.position = new Vector3(23.5f, 2, 0);
        paprika.transform.position = new Vector3(27, 2, 0);
        meat.transform.position = new Vector3(30.5f, 2, 0);
        cucumber.transform.position = new Vector3(34, 2, 0);
        salad.transform.position = new Vector3(37.5f, 2, 0);
        bottomBun.transform.position = new Vector3(41, 2, 0);

    }
    public void EnterButtonDown()
    {
        if (sampleController.random == 0)
        {
            if ((int)((topBun.transform.position.y) * 100) >= 170 &
                (int)((ketchup.transform.position.y) * 100) >= 110 &
                (int)((ketchup.transform.position.y) * 100) <= 130 &
                (int)((onion.transform.position.y) * 100) <= 5 &
                (int)((onion.transform.position.y) * 100) >= -20 &
                (int)((cheese.transform.position.y) * 100) <= 50 &
                (int)((cheese.transform.position.y) * 100) >= 20 &
                (int)((paprika.transform.position.y) * 100) <= -90 &
                (int)((paprika.transform.position.y) * 100) >= -120 &
                (int)((meat.transform.position.y) * 100) <= 100 &
                (int)((meat.transform.position.y) * 100) >= 75 &
                (int)((cucumber.transform.position.y) * 100) <= -130 &
                (int)((cucumber.transform.position.y) * 100) >= -160 &
                (int)((salad.transform.position.y) * 100) <= -40 &
                (int)((salad.transform.position.y) * 100) >= -60 &
                (int)((bottomBun.transform.position.y) * 100) <= -180)
            {
                score += 1;
                this.aud.PlayOneShot(this.scoreSound);
                scoreText.text = string.Format("Score : {0}/{1}", score, endScore);

                sampleController.topBun_s.transform.position = new Vector3(-13, 2, 0);
                sampleController.ketchup_s.transform.position = new Vector3(-16.5f, 2, 0);
                sampleController.onion_s.transform.position = new Vector3(-20, 2, 0);
                sampleController.cheese_s.transform.position = new Vector3(-23.5f, 2, 0);
                sampleController.paprika_s.transform.position = new Vector3(-27, 2, 0);
                sampleController.meat_s.transform.position = new Vector3(-30.5f, 2, 0);
                sampleController.cucumber_s.transform.position = new Vector3(-34, 2, 0);
                sampleController.salad_s.transform.position = new Vector3(-37.5f, 2, 0);
                sampleController.bottomBun_s.transform.position = new Vector3(-41, 2, 0);

                sampleController.sampleBurger();

                topBun.transform.position = new Vector3(13, 2, 0);
                ketchup.transform.position = new Vector3(16.5f, 2, 0);
                onion.transform.position = new Vector3(20, 2, 0);
                cheese.transform.position = new Vector3(23.5f, 2, 0);
                paprika.transform.position = new Vector3(27, 2, 0);
                meat.transform.position = new Vector3(30.5f, 2, 0);
                cucumber.transform.position = new Vector3(34, 2, 0);
                salad.transform.position = new Vector3(37.5f, 2, 0);
                bottomBun.transform.position = new Vector3(41, 2, 0);
            }

        }
        if (sampleController.random == 1)
        {
            if ((int)((topBun.transform.position.y) * 100) >= 170 &
                (int)((ketchup.transform.position.y) * 100) >= -120 &
                (int)((ketchup.transform.position.y) * 100) <= -95 &
                (int)((onion.transform.position.y) * 100) <= -130 &
                (int)((onion.transform.position.y) * 100) >= -160 &
                (int)((cheese.transform.position.y) * 100) <= 100 &
                (int)((cheese.transform.position.y) * 100) >= 80 &
                (int)((paprika.transform.position.y) * 100) <= -40 &
                (int)((paprika.transform.position.y) * 100) >= -65 &
                (int)((meat.transform.position.y) * 100) <= 5 &
                (int)((meat.transform.position.y) * 100) >= -20 &
                (int)((cucumber.transform.position.y) * 100) <= 150 &
                (int)((cucumber.transform.position.y) * 100) >= 110 &
                (int)((salad.transform.position.y) * 100) <= 60 &
                (int)((salad.transform.position.y) * 100) >= 30 &
                (int)((bottomBun.transform.position.y) * 100) <= -180)
            {
                score += 1;
                this.aud.PlayOneShot(this.scoreSound);
                scoreText.text = string.Format("Score : {0}/{1}", score, endScore);

                sampleController.topBun_s.transform.position = new Vector3(-13, 2, 0);
                sampleController.ketchup_s.transform.position = new Vector3(-16.5f, 2, 0);
                sampleController.onion_s.transform.position = new Vector3(-20, 2, 0);
                sampleController.cheese_s.transform.position = new Vector3(-23.5f, 2, 0);
                sampleController.paprika_s.transform.position = new Vector3(-27, 2, 0);
                sampleController.meat_s.transform.position = new Vector3(-30.5f, 2, 0);
                sampleController.cucumber_s.transform.position = new Vector3(-34, 2, 0);
                sampleController.salad_s.transform.position = new Vector3(-37.5f, 2, 0);
                sampleController.bottomBun_s.transform.position = new Vector3(-41, 2, 0);

                sampleController.sampleBurger();

                topBun.transform.position = new Vector3(13, 2, 0);
                ketchup.transform.position = new Vector3(16.5f, 2, 0);
                onion.transform.position = new Vector3(20, 2, 0);
                cheese.transform.position = new Vector3(23.5f, 2, 0);
                paprika.transform.position = new Vector3(27, 2, 0);
                meat.transform.position = new Vector3(30.5f, 2, 0);
                cucumber.transform.position = new Vector3(34, 2, 0);
                salad.transform.position = new Vector3(37.5f, 2, 0);
                bottomBun.transform.position = new Vector3(41, 2, 0);
            }

        }
        if (sampleController.random == 2)
        {
            if ((int)((topBun.transform.position.y) * 100) >= 170 &
                (int)((ketchup.transform.position.y) * 100) >= 20 &
                (int)((ketchup.transform.position.y) * 100) <= 50 &
                (int)((onion.transform.position.y) * 100) <= 145 &
                (int)((onion.transform.position.y) * 100) >= 115 &
                (int)((cheese.transform.position.y) * 100) <= -40 &
                (int)((cheese.transform.position.y) * 100) >= -60 &
                (int)((paprika.transform.position.y) * 100) <= -130 &
                (int)((paprika.transform.position.y) * 100) >= -160 &
                (int)((meat.transform.position.y) * 100) <= 0 &
                (int)((meat.transform.position.y) * 100) >= -30 &
                (int)((cucumber.transform.position.y) * 100) <= -80 &
                (int)((cucumber.transform.position.y) * 100) >= -110 &
                (int)((salad.transform.position.y) * 100) <= 100 &
                (int)((salad.transform.position.y) * 100) >= 70 &
                (int)((bottomBun.transform.position.y) * 100) <= -180)
            {
                score += 1;
                this.aud.PlayOneShot(this.scoreSound);
                scoreText.text = string.Format("Score : {0}/{1}", score, endScore);

                sampleController.topBun_s.transform.position = new Vector3(-13, 2, 0);
                sampleController.ketchup_s.transform.position = new Vector3(-16.5f, 2, 0);
                sampleController.onion_s.transform.position = new Vector3(-20, 2, 0);
                sampleController.cheese_s.transform.position = new Vector3(-23.5f, 2, 0);
                sampleController.paprika_s.transform.position = new Vector3(-27, 2, 0);
                sampleController.meat_s.transform.position = new Vector3(-30.5f, 2, 0);
                sampleController.cucumber_s.transform.position = new Vector3(-34, 2, 0);
                sampleController.salad_s.transform.position = new Vector3(-37.5f, 2, 0);
                sampleController.bottomBun_s.transform.position = new Vector3(-41, 2, 0);

                sampleController.sampleBurger();

                topBun.transform.position = new Vector3(13, 2, 0);
                ketchup.transform.position = new Vector3(16.5f, 2, 0);
                onion.transform.position = new Vector3(20, 2, 0);
                cheese.transform.position = new Vector3(23.5f, 2, 0);
                paprika.transform.position = new Vector3(27, 2, 0);
                meat.transform.position = new Vector3(30.5f, 2, 0);
                cucumber.transform.position = new Vector3(34, 2, 0);
                salad.transform.position = new Vector3(37.5f, 2, 0);
                bottomBun.transform.position = new Vector3(41, 2, 0);
            }

        }
        if (sampleController.random == 3)
        {
            if ((int)((topBun.transform.position.y) * 100) >= 170 &
                (int)((ketchup.transform.position.y) * 100) >= -30 &
                (int)((ketchup.transform.position.y) * 100) <= 0 &
                (int)((onion.transform.position.y) * 100) <= -80 &
                (int)((onion.transform.position.y) * 100) >= -110 &
                (int)((cheese.transform.position.y) * 100) <= -40 &
                (int)((cheese.transform.position.y) * 100) >= -60 &
                (int)((paprika.transform.position.y) * 100) <= 140 &
                (int)((paprika.transform.position.y) * 100) >= 110 &
                (int)((meat.transform.position.y) * 100) <= 50 &
                (int)((meat.transform.position.y) * 100) >= 20 &
                (int)((cucumber.transform.position.y) * 100) <= 90 &
                (int)((cucumber.transform.position.y) * 100) >= 60 &
                (int)((salad.transform.position.y) * 100) <= -130 &
                (int)((salad.transform.position.y) * 100) >= -160 &
                (int)((bottomBun.transform.position.y) * 100) <= -180)
            {
                score += 1;
                this.aud.PlayOneShot(this.scoreSound);
                scoreText.text = string.Format("Score : {0}/{1}", score, endScore);

                sampleController.topBun_s.transform.position = new Vector3(-13, 2, 0);
                sampleController.ketchup_s.transform.position = new Vector3(-16.5f, 2, 0);
                sampleController.onion_s.transform.position = new Vector3(-20, 2, 0);
                sampleController.cheese_s.transform.position = new Vector3(-23.5f, 2, 0);
                sampleController.paprika_s.transform.position = new Vector3(-27, 2, 0);
                sampleController.meat_s.transform.position = new Vector3(-30.5f, 2, 0);
                sampleController.cucumber_s.transform.position = new Vector3(-34, 2, 0);
                sampleController.salad_s.transform.position = new Vector3(-37.5f, 2, 0);
                sampleController.bottomBun_s.transform.position = new Vector3(-41, 2, 0);

                sampleController.sampleBurger();

                topBun.transform.position = new Vector3(13, 2, 0);
                ketchup.transform.position = new Vector3(16.5f, 2, 0);
                onion.transform.position = new Vector3(20, 2, 0);
                cheese.transform.position = new Vector3(23.5f, 2, 0);
                paprika.transform.position = new Vector3(27, 2, 0);
                meat.transform.position = new Vector3(30.5f, 2, 0);
                cucumber.transform.position = new Vector3(34, 2, 0);
                salad.transform.position = new Vector3(37.5f, 2, 0);
                bottomBun.transform.position = new Vector3(41, 2, 0);
            }

        }
        if (sampleController.random == 4)
        {
            if ((int)((topBun.transform.position.y) * 100) >= 170 &
                (int)((ketchup.transform.position.y) * 100) >= -80 &
                (int)((ketchup.transform.position.y) * 100) <= -50 &
                (int)((onion.transform.position.y) * 100) <= 40 &
                (int)((onion.transform.position.y) * 100) >= 20 &
                (int)((cheese.transform.position.y) * 100) <= -130 &
                (int)((cheese.transform.position.y) * 100) >= -170 &
                (int)((paprika.transform.position.y) * 100) <= 0 &
                (int)((paprika.transform.position.y) * 100) >= -30 &
                (int)((meat.transform.position.y) * 100) <= 100 &
                (int)((meat.transform.position.y) * 100) >= 60 &
                (int)((cucumber.transform.position.y) * 100) <= -90 &
                (int)((cucumber.transform.position.y) * 100) >= -120 &
                (int)((salad.transform.position.y) * 100) <= 140 &
                (int)((salad.transform.position.y) * 100) >= 110 &
                (int)((bottomBun.transform.position.y) * 100) <= -180)
            {
                score += 1;
                this.aud.PlayOneShot(this.scoreSound);
                scoreText.text = string.Format("Score : {0}/{1}", score, endScore);

                sampleController.topBun_s.transform.position = new Vector3(-13, 2, 0);
                sampleController.ketchup_s.transform.position = new Vector3(-16.5f, 2, 0);
                sampleController.onion_s.transform.position = new Vector3(-20, 2, 0);
                sampleController.cheese_s.transform.position = new Vector3(-23.5f, 2, 0);
                sampleController.paprika_s.transform.position = new Vector3(-27, 2, 0);
                sampleController.meat_s.transform.position = new Vector3(-30.5f, 2, 0);
                sampleController.cucumber_s.transform.position = new Vector3(-34, 2, 0);
                sampleController.salad_s.transform.position = new Vector3(-37.5f, 2, 0);
                sampleController.bottomBun_s.transform.position = new Vector3(-41, 2, 0);

                sampleController.sampleBurger();

                topBun.transform.position = new Vector3(13, 2, 0);
                ketchup.transform.position = new Vector3(16.5f, 2, 0);
                onion.transform.position = new Vector3(20, 2, 0);
                cheese.transform.position = new Vector3(23.5f, 2, 0);
                paprika.transform.position = new Vector3(27, 2, 0);
                meat.transform.position = new Vector3(30.5f, 2, 0);
                cucumber.transform.position = new Vector3(34, 2, 0);
                salad.transform.position = new Vector3(37.5f, 2, 0);
                bottomBun.transform.position = new Vector3(41, 2, 0);
            }

        }
        if (sampleController.random == 5)
        {
            if ((int)((topBun.transform.position.y) * 100) >= 170 &
                (int)((ketchup.transform.position.y) * 100) >= -70 &
                (int)((ketchup.transform.position.y) * 100) <= -40 &
                (int)((onion.transform.position.y) * 100) <= 60 &
                (int)((onion.transform.position.y) * 100) >= 30 &
                (int)((cheese.transform.position.y) * 100) <= 150 &
                (int)((cheese.transform.position.y) * 100) >= 120 &
                (int)((paprika.transform.position.y) * 100) <= -90 &
                (int)((paprika.transform.position.y) * 100) >= -120 &
                (int)((meat.transform.position.y) * 100) <= 110 &
                (int)((meat.transform.position.y) * 100) >= 80 &
                (int)((cucumber.transform.position.y) * 100) <= 140 &
                (int)((cucumber.transform.position.y) * 100) >= -160 &
                (int)((salad.transform.position.y) * 100) <= 10 &
                (int)((salad.transform.position.y) * 100) >= -20 &
                (int)((bottomBun.transform.position.y) * 100) <= -180)
            {
                score += 1;
                this.aud.PlayOneShot(this.scoreSound);
                scoreText.text = string.Format("Score : {0}/{1}", score, endScore);

                sampleController.topBun_s.transform.position = new Vector3(-13, 2, 0);
                sampleController.ketchup_s.transform.position = new Vector3(-16.5f, 2, 0);
                sampleController.onion_s.transform.position = new Vector3(-20, 2, 0);
                sampleController.cheese_s.transform.position = new Vector3(-23.5f, 2, 0);
                sampleController.paprika_s.transform.position = new Vector3(-27, 2, 0);
                sampleController.meat_s.transform.position = new Vector3(-30.5f, 2, 0);
                sampleController.cucumber_s.transform.position = new Vector3(-34, 2, 0);
                sampleController.salad_s.transform.position = new Vector3(-37.5f, 2, 0);
                sampleController.bottomBun_s.transform.position = new Vector3(-41, 2, 0);

                sampleController.sampleBurger();

                topBun.transform.position = new Vector3(13, 2, 0);
                ketchup.transform.position = new Vector3(16.5f, 2, 0);
                onion.transform.position = new Vector3(20, 2, 0);
                cheese.transform.position = new Vector3(23.5f, 2, 0);
                paprika.transform.position = new Vector3(27, 2, 0);
                meat.transform.position = new Vector3(30.5f, 2, 0);
                cucumber.transform.position = new Vector3(34, 2, 0);
                salad.transform.position = new Vector3(37.5f, 2, 0);
                bottomBun.transform.position = new Vector3(41, 2, 0);
            }

        }
        if (sampleController.random == 6)
        {
            if ((int)((topBun.transform.position.y) * 100) >= 170 &
                (int)((ketchup.transform.position.y) * 100) >= 110 &
                (int)((ketchup.transform.position.y) * 100) <= 140 &
                (int)((onion.transform.position.y) * 100) <= -40 &
                (int)((onion.transform.position.y) * 100) >= -70 &
                (int)((cheese.transform.position.y) * 100) <= 0 &
                (int)((cheese.transform.position.y) * 100) >= -20 &
                (int)((paprika.transform.position.y) * 100) <= 50 &
                (int)((paprika.transform.position.y) * 100) >= 20 &
                (int)((meat.transform.position.y) * 100) <= -130 &
                (int)((meat.transform.position.y) * 100) >=-160 &
                (int)((cucumber.transform.position.y) * 100) <= 100 &
                (int)((cucumber.transform.position.y) * 100) >= 70 &
                (int)((salad.transform.position.y) * 100) <= -90 &
                (int)((salad.transform.position.y) * 100) >= -120 &
                (int)((bottomBun.transform.position.y) * 100) <= -180)
            {
                score += 1;
                this.aud.PlayOneShot(this.scoreSound);
                scoreText.text = string.Format("Score : {0}/{1}", score, endScore);

                sampleController.topBun_s.transform.position = new Vector3(-13, 2, 0);
                sampleController.ketchup_s.transform.position = new Vector3(-16.5f, 2, 0);
                sampleController.onion_s.transform.position = new Vector3(-20, 2, 0);
                sampleController.cheese_s.transform.position = new Vector3(-23.5f, 2, 0);
                sampleController.paprika_s.transform.position = new Vector3(-27, 2, 0);
                sampleController.meat_s.transform.position = new Vector3(-30.5f, 2, 0);
                sampleController.cucumber_s.transform.position = new Vector3(-34, 2, 0);
                sampleController.salad_s.transform.position = new Vector3(-37.5f, 2, 0);
                sampleController.bottomBun_s.transform.position = new Vector3(-41, 2, 0);

                sampleController.sampleBurger();

                topBun.transform.position = new Vector3(13, 2, 0);
                ketchup.transform.position = new Vector3(16.5f, 2, 0);
                onion.transform.position = new Vector3(20, 2, 0);
                cheese.transform.position = new Vector3(23.5f, 2, 0);
                paprika.transform.position = new Vector3(27, 2, 0);
                meat.transform.position = new Vector3(30.5f, 2, 0);
                cucumber.transform.position = new Vector3(34, 2, 0);
                salad.transform.position = new Vector3(37.5f, 2, 0);
                bottomBun.transform.position = new Vector3(41, 2, 0);
            }

        }
        if (sampleController.random == 7)
        {
            if ((int)((topBun.transform.position.y) * 100) >= 170 &
                (int)((ketchup.transform.position.y) * 100) >= 60 &
                (int)((ketchup.transform.position.y) * 100) <= 90 &
                (int)((onion.transform.position.y) * 100) <= 0 &
                (int)((onion.transform.position.y) * 100) >= -30 &
                (int)((cheese.transform.position.y) * 100) <= -50 &
                (int)((cheese.transform.position.y) * 100) >= -70 &
                (int)((paprika.transform.position.y) * 100) <= 140 &
                (int)((paprika.transform.position.y) * 100) >= 110 &
                (int)((meat.transform.position.y) * 100) <= 50 &
                (int)((meat.transform.position.y) * 100) >= 20 &
                (int)((cucumber.transform.position.y) * 100) <= -140 &
                (int)((cucumber.transform.position.y) * 100) >= -160 &
                (int)((salad.transform.position.y) * 100) <= -90 &
                (int)((salad.transform.position.y) * 100) >= -120 &
                (int)((bottomBun.transform.position.y) * 100) <= -180)
            {
                score += 1;
                this.aud.PlayOneShot(this.scoreSound);
                scoreText.text = string.Format("Score : {0}/{1}", score, endScore);

                sampleController.topBun_s.transform.position = new Vector3(-13, 2, 0);
                sampleController.ketchup_s.transform.position = new Vector3(-16.5f, 2, 0);
                sampleController.onion_s.transform.position = new Vector3(-20, 2, 0);
                sampleController.cheese_s.transform.position = new Vector3(-23.5f, 2, 0);
                sampleController.paprika_s.transform.position = new Vector3(-27, 2, 0);
                sampleController.meat_s.transform.position = new Vector3(-30.5f, 2, 0);
                sampleController.cucumber_s.transform.position = new Vector3(-34, 2, 0);
                sampleController.salad_s.transform.position = new Vector3(-37.5f, 2, 0);
                sampleController.bottomBun_s.transform.position = new Vector3(-41, 2, 0);

                sampleController.sampleBurger();

                topBun.transform.position = new Vector3(13, 2, 0);
                ketchup.transform.position = new Vector3(16.5f, 2, 0);
                onion.transform.position = new Vector3(20, 2, 0);
                cheese.transform.position = new Vector3(23.5f, 2, 0);
                paprika.transform.position = new Vector3(27, 2, 0);
                meat.transform.position = new Vector3(30.5f, 2, 0);
                cucumber.transform.position = new Vector3(34, 2, 0);
                salad.transform.position = new Vector3(37.5f, 2, 0);
                bottomBun.transform.position = new Vector3(41, 2, 0);
            }

        }
        if (sampleController.random == 8)
        {
            if ((int)((topBun.transform.position.y) * 100) >= 170 &
                (int)((ketchup.transform.position.y) * 100) >= -150 &
                (int)((ketchup.transform.position.y) * 100) <= -130 &
                (int)((onion.transform.position.y) * 100) <= -30 &
                (int)((onion.transform.position.y) * 100) >= -60 &
                (int)((cheese.transform.position.y) * 100) <= 60 &
                (int)((cheese.transform.position.y) * 100) >= 20 &
                (int)((paprika.transform.position.y) * 100) <= 100  &
                (int)((paprika.transform.position.y) * 100) >= 70 &
                (int)((meat.transform.position.y) * 100) <= 5 &
                (int)((meat.transform.position.y) * 100) >= -20 &
                (int)((cucumber.transform.position.y) * 100) <= 150 &
                (int)((cucumber.transform.position.y) * 100) >= 120 &
                (int)((salad.transform.position.y) * 100) <= -80 &
                (int)((salad.transform.position.y) * 100) >= -110 &
                (int)((bottomBun.transform.position.y) * 100) <= -180)
            {
                score += 1;
                this.aud.PlayOneShot(this.scoreSound);
                scoreText.text = string.Format("Score : {0}/{1}", score, endScore);

                sampleController.topBun_s.transform.position = new Vector3(-13, 2, 0);
                sampleController.ketchup_s.transform.position = new Vector3(-16.5f, 2, 0);
                sampleController.onion_s.transform.position = new Vector3(-20, 2, 0);
                sampleController.cheese_s.transform.position = new Vector3(-23.5f, 2, 0);
                sampleController.paprika_s.transform.position = new Vector3(-27, 2, 0);
                sampleController.meat_s.transform.position = new Vector3(-30.5f, 2, 0);
                sampleController.cucumber_s.transform.position = new Vector3(-34, 2, 0);
                sampleController.salad_s.transform.position = new Vector3(-37.5f, 2, 0);
                sampleController.bottomBun_s.transform.position = new Vector3(-41, 2, 0);

                sampleController.sampleBurger();

                topBun.transform.position = new Vector3(13, 2, 0);
                ketchup.transform.position = new Vector3(16.5f, 2, 0);
                onion.transform.position = new Vector3(20, 2, 0);
                cheese.transform.position = new Vector3(23.5f, 2, 0);
                paprika.transform.position = new Vector3(27, 2, 0);
                meat.transform.position = new Vector3(30.5f, 2, 0);
                cucumber.transform.position = new Vector3(34, 2, 0);
                salad.transform.position = new Vector3(37.5f, 2, 0);
                bottomBun.transform.position = new Vector3(41, 2, 0);
            }

        }
        if (score == 8)
        {
            SceneManager.LoadScene("ClearScene3");
        }
    }
}

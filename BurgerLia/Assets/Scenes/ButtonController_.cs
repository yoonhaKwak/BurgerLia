using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonController_ : MonoBehaviour
{
    GameObject topBun;
    GameObject ketchup;
    GameObject cheese;
    GameObject paprika;
    GameObject chicken;
    GameObject salad;
    GameObject bottomBun;
    sampleController1 sampleController;
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
        this.cheese = GameObject.Find("cheese");
        this.paprika = GameObject.Find("paprika");
        this.chicken = GameObject.Find("chicken");
        this.salad = GameObject.Find("salad");
        this.bottomBun = GameObject.Find("bottomBun");
        this.sampleController = GameObject.Find("topBun_s").GetComponent<sampleController1>();
        this.aud = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void topBunButtonDown()
    {
        transform.Translate(-9, 0, 0);
    }
    public void ketchupButtonDown()
    {
        transform.Translate(-12.5f, 0, 0);
    }
    public void cheeseButtonDown()
    {
        transform.Translate(-16, 0, 0);
    }
    public void paprikaButtonDown()
    {
        transform.Translate(-19.5f, 0, 0);
    }
    public void chickenButtonDown()
    {
        transform.Translate(-23, 0, 0);
    }
    public void saladButtonDown()
    {
        transform.Translate(-26.5f, 0, 0);
    }
    public void bottomBunButtonDown()
    {
        transform.Translate(-30, 0, 0);
    }
    public void clearButtonDown()
    {
        topBun.transform.position = new Vector3(13, 2, 0);
        ketchup.transform.position = new Vector3(16.5f,2, 0);
        cheese.transform.position = new Vector3(20, 2, 0);
        paprika.transform.position = new Vector3(23.5f, 2, 0);
        chicken.transform.position = new Vector3(27, 2, 0);
        salad.transform.position = new Vector3(30.5f, 2, 0);
        bottomBun.transform.position = new Vector3(34, 2, 0);

    }
    public void EnterButtonDown()
    {
        if (sampleController.random == 0)
        {
            if ((int)((topBun.transform.position.y) * 100) >= 70 &
                (int)((ketchup.transform.position.y) * 100) >= 25 &
                (int)((ketchup.transform.position.y) * 100) <= 45 &
                (int)((cheese.transform.position.y) * 100) <= -5 &
                (int)((cheese.transform.position.y) * 100) >= -20 &
                (int)((paprika.transform.position.y) * 100) <= -40 &
                (int)((paprika.transform.position.y) * 100) >= -60 &
                (int)((chicken.transform.position.y) * 100) <= -80 &
                (int)((chicken.transform.position.y) * 100) >= -100 &
                (int)((salad.transform.position.y) * 100) <= -130 &
                (int)((salad.transform.position.y) * 100) >= -150&
                (int)((bottomBun.transform.position.y) * 100) <= -170)
            {
                score += 1;
                this.aud.PlayOneShot(this.scoreSound);
                scoreText.text = string.Format("Score : {0}/{1}", score, endScore);

                sampleController.topBun_s.transform.position = new Vector3(-34, 2, 0);
                sampleController.ketchup_s.transform.position = new Vector3(-30.5f, 2, 0);
                sampleController.cheese_s.transform.position = new Vector3(-27, 2, 0);
                sampleController.paprika_s.transform.position = new Vector3(-23.5f, 2, 0);
                sampleController.chicken_s.transform.position = new Vector3(-20, 2, 0);
                sampleController.salad_s.transform.position = new Vector3(-16.5f, 2, 0);
                sampleController.bottomBun_s.transform.position = new Vector3(-13, 2, 0);

                sampleController.sampleBurger();

                topBun.transform.position = new Vector3(13, 2, 0);
                ketchup.transform.position = new Vector3(16.5f, 2, 0);
                cheese.transform.position = new Vector3(20, 2, 0);
                paprika.transform.position = new Vector3(23.5f, 2, 0);
                chicken.transform.position = new Vector3(27, 2, 0);
                salad.transform.position = new Vector3(30.5f, 2, 0);
                bottomBun.transform.position = new Vector3(34, 2, 0);
            }

        }
        if (sampleController.random == 1)
        {
            if ((int)((topBun.transform.position.y) * 100) >= 70 &
                (int)((ketchup.transform.position.y) * 100) >= -105 &
                (int)((ketchup.transform.position.y) * 100) <= -85&
                (int)((cheese.transform.position.y) * 100) <= 45 &
                (int)((cheese.transform.position.y) * 100) >= 25 &
                (int)((paprika.transform.position.y) * 100) <= -130 &
                (int)((paprika.transform.position.y) * 100) >= -155 &
                (int)((chicken.transform.position.y) * 100) <= -40 &
                (int)((chicken.transform.position.y) * 100) >= -60 &
                (int)((salad.transform.position.y) * 100) <= 10 &
                (int)((salad.transform.position.y) * 100) >= -20 &
                (int)((bottomBun.transform.position.y) * 100) <= -170)
            {
                score += 1;
                this.aud.PlayOneShot(this.scoreSound);
                scoreText.text = string.Format("Score : {0}/{1}", score, endScore);

                sampleController.topBun_s.transform.position = new Vector3(-34, 2, 0);
                sampleController.ketchup_s.transform.position = new Vector3(-30.5f, 2, 0);
                sampleController.cheese_s.transform.position = new Vector3(-27, 2, 0);
                sampleController.paprika_s.transform.position = new Vector3(-23.5f, 2, 0);
                sampleController.chicken_s.transform.position = new Vector3(-20, 2, 0);
                sampleController.salad_s.transform.position = new Vector3(-16.5f, 2, 0);
                sampleController.bottomBun_s.transform.position = new Vector3(-13, 2, 0);

                sampleController.sampleBurger();

                topBun.transform.position = new Vector3(13, 2, 0);
                ketchup.transform.position = new Vector3(16.5f, 2, 0);
                cheese.transform.position = new Vector3(20, 2, 0);
                paprika.transform.position = new Vector3(23.5f, 2, 0);
                chicken.transform.position = new Vector3(27, 2, 0);
                salad.transform.position = new Vector3(30.5f, 2, 0);
                bottomBun.transform.position = new Vector3(34, 2, 0);
            }

        }
        if (sampleController.random == 2)
        {
            if ((int)((topBun.transform.position.y) * 100) >= 70 &
                (int)((ketchup.transform.position.y) * 100) >= -130 &
                (int)((ketchup.transform.position.y) * 100) <= -105 &
                (int)((cheese.transform.position.y) * 100) <= -140 &
                (int)((cheese.transform.position.y) * 100) >= -170 &
                (int)((paprika.transform.position.y) * 100) <= 45&
                (int)((paprika.transform.position.y) * 100) >= 15 &
                (int)((chicken.transform.position.y) * 100) <= 0 &
                (int)((chicken.transform.position.y) * 100) >= -30 &
                (int)((salad.transform.position.y) * 100) <= -40 &
                (int)((salad.transform.position.y) * 100) >= -80 &
                (int)((bottomBun.transform.position.y) * 100) <= -170)
            {
                score += 1;
                this.aud.PlayOneShot(this.scoreSound);
                scoreText.text = string.Format("Score : {0}/{1}", score, endScore);

                sampleController.topBun_s.transform.position = new Vector3(-34, 2, 0);
                sampleController.ketchup_s.transform.position = new Vector3(-30.5f, 2, 0);
                sampleController.cheese_s.transform.position = new Vector3(-27, 2, 0);
                sampleController.paprika_s.transform.position = new Vector3(-23.5f, 2, 0);
                sampleController.chicken_s.transform.position = new Vector3(-20, 2, 0);
                sampleController.salad_s.transform.position = new Vector3(-16.5f, 2, 0);
                sampleController.bottomBun_s.transform.position = new Vector3(-13, 2, 0);

                sampleController.sampleBurger();

                topBun.transform.position = new Vector3(13, 2, 0);
                ketchup.transform.position = new Vector3(16.5f, 2, 0);
                cheese.transform.position = new Vector3(20, 2, 0);
                paprika.transform.position = new Vector3(23.5f, 2, 0);
                chicken.transform.position = new Vector3(27, 2, 0);
                salad.transform.position = new Vector3(30.5f, 2, 0);
                bottomBun.transform.position = new Vector3(34, 2, 0);
            }

        }
        if (sampleController.random == 3)
        {
            if ((int)((topBun.transform.position.y) * 100) >= 70 &
                (int)((ketchup.transform.position.y) * 100) >= -75 &
                (int)((ketchup.transform.position.y) * 100) <= -50 &
                (int)((cheese.transform.position.y) * 100) <= -80 &
                (int)((cheese.transform.position.y) * 100) >= -120 &
                (int)((paprika.transform.position.y) * 100) <= -130 &
                (int)((paprika.transform.position.y) * 100) >= -160 &
                (int)((chicken.transform.position.y) * 100) <= 50 &
                (int)((chicken.transform.position.y) * 100) >= 20 &
                (int)((salad.transform.position.y) * 100) <= -2 &
                (int)((salad.transform.position.y) * 100) >= -30 &
                (int)((bottomBun.transform.position.y) * 100) <= -170)
            {
                score += 1;
                this.aud.PlayOneShot(this.scoreSound);
                scoreText.text = string.Format("Score : {0}/{1}", score, endScore);

                sampleController.topBun_s.transform.position = new Vector3(-34, 2, 0);
                sampleController.ketchup_s.transform.position = new Vector3(-30.5f, 2, 0);
                sampleController.cheese_s.transform.position = new Vector3(-27, 2, 0);
                sampleController.paprika_s.transform.position = new Vector3(-23.5f, 2, 0);
                sampleController.chicken_s.transform.position = new Vector3(-20, 2, 0);
                sampleController.salad_s.transform.position = new Vector3(-16.5f, 2, 0);
                sampleController.bottomBun_s.transform.position = new Vector3(-13, 2, 0);

                sampleController.sampleBurger();

                topBun.transform.position = new Vector3(13, 2, 0);
                ketchup.transform.position = new Vector3(16.5f, 2, 0);
                cheese.transform.position = new Vector3(20, 2, 0);
                paprika.transform.position = new Vector3(23.5f, 2, 0);
                chicken.transform.position = new Vector3(27, 2, 0);
                salad.transform.position = new Vector3(30.5f, 2, 0);
                bottomBun.transform.position = new Vector3(34, 2, 0);
            }

        }
        if (sampleController.random == 4)
        {
            if ((int)((topBun.transform.position.y) * 100) >= 70 &
                (int)((ketchup.transform.position.y) * 100) >= -30 &
                (int)((ketchup.transform.position.y) * 100) <= -2 &
                (int)((cheese.transform.position.y) * 100) <= -140 &
                (int)((cheese.transform.position.y) * 100) >= -170 &
                (int)((paprika.transform.position.y) * 100) <= -55 &
                (int)((paprika.transform.position.y) * 100) >= -85 &
                (int)((chicken.transform.position.y) * 100) <= -100 &
                (int)((chicken.transform.position.y) * 100) >= -130 &
                (int)((salad.transform.position.y) * 100) <= 50 &
                (int)((salad.transform.position.y) * 100) >= 20 &
                (int)((bottomBun.transform.position.y) * 100) <= -170)
            {
                score += 1;
                this.aud.PlayOneShot(this.scoreSound);
                scoreText.text = string.Format("Score : {0}/{1}", score, endScore);

                sampleController.topBun_s.transform.position = new Vector3(-34, 2, 0);
                sampleController.ketchup_s.transform.position = new Vector3(-30.5f, 2, 0);
                sampleController.cheese_s.transform.position = new Vector3(-27, 2, 0);
                sampleController.paprika_s.transform.position = new Vector3(-23.5f, 2, 0);
                sampleController.chicken_s.transform.position = new Vector3(-20, 2, 0);
                sampleController.salad_s.transform.position = new Vector3(-16.5f, 2, 0);
                sampleController.bottomBun_s.transform.position = new Vector3(-13, 2, 0);

                sampleController.sampleBurger();

                topBun.transform.position = new Vector3(13, 2, 0);
                ketchup.transform.position = new Vector3(16.5f, 2, 0);
                cheese.transform.position = new Vector3(20, 2, 0);
                paprika.transform.position = new Vector3(23.5f, 2, 0);
                chicken.transform.position = new Vector3(27, 2, 0);
                salad.transform.position = new Vector3(30.5f, 2, 0);
                bottomBun.transform.position = new Vector3(34, 2, 0);
            }

        }
        if (sampleController.random == 5)
        {
            if ((int)((topBun.transform.position.y) * 100) >= 70 &
                (int)((ketchup.transform.position.y) * 100) >= -120 &
                (int)((ketchup.transform.position.y) * 100) <= -90 &
                (int)((cheese.transform.position.y) * 100) <= -2 &
                (int)((cheese.transform.position.y) * 100) >= -30 &
                (int)((paprika.transform.position.y) * 100) <= 45 &
                (int)((paprika.transform.position.y) * 100) >= 15 &
                (int)((chicken.transform.position.y) * 100) <= -130 &
                (int)((chicken.transform.position.y) * 100) >= -170 &
                (int)((salad.transform.position.y) * 100) <= -35 &
                (int)((salad.transform.position.y) * 100) >= -75 &
                (int)((bottomBun.transform.position.y) * 100) <= -170)
            {
                score += 1;
                this.aud.PlayOneShot(this.scoreSound);
                scoreText.text = string.Format("Score : {0}/{1}", score, endScore);

                sampleController.topBun_s.transform.position = new Vector3(-34, 2, 0);
                sampleController.ketchup_s.transform.position = new Vector3(-30.5f, 2, 0);
                sampleController.cheese_s.transform.position = new Vector3(-27, 2, 0);
                sampleController.paprika_s.transform.position = new Vector3(-23.5f, 2, 0);
                sampleController.chicken_s.transform.position = new Vector3(-20, 2, 0);
                sampleController.salad_s.transform.position = new Vector3(-16.5f, 2, 0);
                sampleController.bottomBun_s.transform.position = new Vector3(-13, 2, 0);

                sampleController.sampleBurger();

                topBun.transform.position = new Vector3(13, 2, 0);
                ketchup.transform.position = new Vector3(16.5f, 2, 0);
                cheese.transform.position = new Vector3(20, 2, 0);
                paprika.transform.position = new Vector3(23.5f, 2, 0);
                chicken.transform.position = new Vector3(27, 2, 0);
                salad.transform.position = new Vector3(30.5f, 2, 0);
                bottomBun.transform.position = new Vector3(34, 2, 0);
            }

        }
        
        if (score == 8)
        {
            SceneManager.LoadScene("ClearScene2");
        }

    }
     

}

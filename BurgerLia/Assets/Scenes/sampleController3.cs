using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sampleController3 : MonoBehaviour
{
    public GameObject topBun_s;
    public GameObject ketchup_s;
    public GameObject onion_s;
    public GameObject cheese_s;
    public GameObject paprika_s;
    public GameObject meat_s;
    public GameObject cucumber_s;
    public GameObject salad_s;
    public GameObject bottomBun_s;
    public int random;
    public SpriteRenderer topBun_s_;
    public SpriteRenderer ketchup_s_;
    public SpriteRenderer onion_s_;
    public SpriteRenderer cheese_s_;
    public SpriteRenderer paprika_s_;
    public SpriteRenderer meat_s_;
    public SpriteRenderer cucumber_s_;
    public SpriteRenderer salad_s_;
    public SpriteRenderer bottomBun_s_;

    public SpriteRenderer topBun;
    public SpriteRenderer ketchup;
    public SpriteRenderer onion;
    public SpriteRenderer cheese;
    public SpriteRenderer paprika;
    public SpriteRenderer meat;
    public SpriteRenderer cucumber;
    public SpriteRenderer salad;
    public SpriteRenderer bottomBun;
    // Start is called before the first frame update
    void Start()
    {
        this.topBun_s = GameObject.Find("topBun_s");
        this.ketchup_s = GameObject.Find("ketchup_s");
        this.onion_s = GameObject.Find("onion_s");
        this.cheese_s = GameObject.Find("cheese_s");
        this.paprika_s = GameObject.Find("paprika_s");
        this.meat_s = GameObject.Find("meat_s");
        this.cucumber_s = GameObject.Find("cucumber_s");
        this.salad_s = GameObject.Find("salad_s");
        this.bottomBun_s = GameObject.Find("bottomBun_s");

        sampleBurger();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void sampleBurger()
    {
        random = Random.Range(0, 9);
        topBun_s.transform.Translate(9, 2.5f, 0);
        bottomBun_s.transform.Translate(37, -2, 0);

        switch (random)
        {
            case 0:
                ketchup_s.transform.Translate(12.5f, 1.5f, 0);
                ketchup_s_.sortingOrder = 7;
                ketchup.sortingOrder = 7;
                onion_s.transform.Translate(16, 0.5f, 0);
                onion_s_.sortingOrder = 4;
                onion.sortingOrder = 4;
                cheese_s.transform.Translate(19.5f, 0.7f, 0);
                cheese_s_.sortingOrder = 5;
                cheese.sortingOrder = 5;
                paprika_s.transform.Translate(23, -0.5f, 0);
                paprika_s_.sortingOrder = 2;
                paprika.sortingOrder = 2;
                meat_s.transform.Translate(26.5f, 1, 0);
                meat_s_.sortingOrder = 6;
                meat.sortingOrder = 6;
                cucumber_s.transform.Translate(30, -1, 0);
                cucumber_s_.sortingOrder = 1;
                cucumber.sortingOrder = 1;
                salad_s.transform.Translate(33.5f, 0, 0);
                salad_s_.sortingOrder = 3;
                salad.sortingOrder = 3;
                break;
            case 1:
                ketchup_s.transform.Translate(12.5f, -0.5f, 0);
                ketchup_s_.sortingOrder = 2;
                ketchup.sortingOrder = 2;
                onion_s.transform.Translate(16, -1, 0);
                onion_s_.sortingOrder = 1;
                onion.sortingOrder = 1;
                cheese_s.transform.Translate(19.5f, 1, 0);
                cheese_s_.sortingOrder = 6;
                cheese.sortingOrder = 6;
                paprika_s.transform.Translate(23, 0, 0);
                paprika_s_.sortingOrder = 3;
                paprika.sortingOrder = 3;
                meat_s.transform.Translate(26.5f, 0.5f, 0);
                meat_s_.sortingOrder = 4;
                meat.sortingOrder = 4;
                cucumber_s.transform.Translate(30, 1.5f, 0);
                cucumber_s_.sortingOrder = 7;
                cucumber.sortingOrder = 7;
                salad_s.transform.Translate(33.5f, 0.7f, 0);
                salad_s_.sortingOrder = 5;
                salad.sortingOrder = 5;
                break;
            case 2:
                ketchup_s.transform.Translate(12.5f, 0.7f, 0);
                ketchup_s_.sortingOrder = 5;
                ketchup.sortingOrder = 5;
                onion_s.transform.Translate(16, 1.5f, 0);
                onion_s_.sortingOrder = 7;
                onion.sortingOrder = 7;
                cheese_s.transform.Translate(19.5f, 0, 0);
                cheese_s_.sortingOrder = 3;
                cheese.sortingOrder = 3;
                paprika_s.transform.Translate(23, -1, 0);
                paprika_s_.sortingOrder = 1;
                paprika.sortingOrder = 1;
                meat_s.transform.Translate(26.5f, 0.5f, 0);
                meat_s_.sortingOrder = 4;
                meat.sortingOrder = 4;
                cucumber_s.transform.Translate(30, -0.5f, 0);
                cucumber_s_.sortingOrder = 2;
                cucumber.sortingOrder = 2;
                salad_s.transform.Translate(33.5f, 1, 0);
                salad_s_.sortingOrder = 6;
                salad.sortingOrder = 6;
                break;
            case 3:
                ketchup_s.transform.Translate(12.5f, 0.5f, 0);
                ketchup_s_.sortingOrder = 4;
                ketchup.sortingOrder = 4;
                onion_s.transform.Translate(16, -0.5f, 0);
                onion_s_.sortingOrder = 2;
                onion.sortingOrder = 2;
                cheese_s.transform.Translate(19.5f, 0, 0);
                cheese_s_.sortingOrder = 3;
                cheese.sortingOrder = 3;
                paprika_s.transform.Translate(23, 1.5f, 0);
                paprika_s_.sortingOrder = 7;
                paprika.sortingOrder = 7;
                meat_s.transform.Translate(26.5f, 0.7f, 0);
                meat_s_.sortingOrder = 5;
                meat.sortingOrder = 5;
                cucumber_s.transform.Translate(30, 1, 0);
                cucumber_s_.sortingOrder = 6;
                cucumber.sortingOrder = 6;
                salad_s.transform.Translate(33.5f, -1, 0);
                salad_s_.sortingOrder = 1;
                salad.sortingOrder = 1;
                break;
            case 4:
                ketchup_s.transform.Translate(12.5f, 0, 0);
                ketchup_s_.sortingOrder = 3;
                ketchup.sortingOrder = 3;
                onion_s.transform.Translate(16, 0.7f, 0);
                onion_s_.sortingOrder = 5;
                onion.sortingOrder = 5;
                cheese_s.transform.Translate(19.5f, -1, 0);
                cheese_s_.sortingOrder = 1;
                cheese.sortingOrder = 1;
                paprika_s.transform.Translate(23, 0.5f, 0);
                paprika_s_.sortingOrder = 4;
                paprika.sortingOrder = 4;
                meat_s.transform.Translate(26.5f, 1, 0);
                meat_s_.sortingOrder = 6;
                meat.sortingOrder = 6;
                cucumber_s.transform.Translate(30, -0.5f, 0);
                cucumber_s_.sortingOrder = 2;
                cucumber.sortingOrder = 2;
                salad_s.transform.Translate(33.5f, 1.5f, 0);
                salad_s_.sortingOrder = 7;
                salad.sortingOrder = 7;
                break;
            case 5:
                ketchup_s.transform.Translate(12.5f, 0, 0);
                ketchup_s_.sortingOrder = 3;
                ketchup.sortingOrder = 3;
                onion_s.transform.Translate(16, 0.7f, 0);
                onion_s_.sortingOrder = 5;
                onion.sortingOrder = 5;
                cheese_s.transform.Translate(19.5f, 1.5f, 0);
                cheese_s_.sortingOrder = 7;
                cheese.sortingOrder = 7;
                paprika_s.transform.Translate(23, -0.5f, 0);
                paprika_s_.sortingOrder = 2;
                paprika.sortingOrder = 2;
                meat_s.transform.Translate(26.5f, 1, 0);
                meat_s_.sortingOrder = 6;
                meat.sortingOrder = 6;
                cucumber_s.transform.Translate(30, -1, 0);
                cucumber_s_.sortingOrder = 1;
                cucumber.sortingOrder = 1;
                salad_s.transform.Translate(33.5f, 0.5f, 0);
                salad_s_.sortingOrder = 4;
                salad.sortingOrder = 4;
                break;
            case 6:
                ketchup_s.transform.Translate(12.5f, 1.5f, 0);
                ketchup_s_.sortingOrder = 7;
                ketchup.sortingOrder = 7;
                onion_s.transform.Translate(16, 0, 0);
                onion_s_.sortingOrder = 3;
                onion.sortingOrder = 3;
                cheese_s.transform.Translate(19.5f, 0.5f, 0);
                cheese_s_.sortingOrder = 4;
                cheese.sortingOrder = 4;
                paprika_s.transform.Translate(23, 0.7f, 0);
                paprika_s_.sortingOrder = 5;
                paprika.sortingOrder = 5;
                meat_s.transform.Translate(26.5f, -1, 0);
                meat_s_.sortingOrder = 1;
                meat.sortingOrder = 1;
                cucumber_s.transform.Translate(30, 1, 0);
                cucumber_s_.sortingOrder = 6;
                cucumber.sortingOrder = 6;
                salad_s.transform.Translate(33.5f, -0.5f, 0);
                salad_s_.sortingOrder = 2;
                salad.sortingOrder = 2;
                break;
            case 7:
                ketchup_s.transform.Translate(12.5f, 1, 0);
                ketchup_s_.sortingOrder = 6;
                ketchup.sortingOrder = 6;
                onion_s.transform.Translate(16, 0.5f, 0);
                onion_s_.sortingOrder = 4;
                onion.sortingOrder = 4;
                cheese_s.transform.Translate(19.5f, 0, 0);
                cheese_s_.sortingOrder = 3;
                cheese.sortingOrder = 3;
                paprika_s.transform.Translate(23, 1.5f, 0);
                paprika_s_.sortingOrder = 7;
                paprika.sortingOrder = 7;
                meat_s.transform.Translate(26.5f, 0.7f, 0);
                meat_s_.sortingOrder = 5;
                meat.sortingOrder = 5;
                cucumber_s.transform.Translate(30, -1, 0);
                cucumber_s_.sortingOrder = 1;
                cucumber.sortingOrder = 1;
                salad_s.transform.Translate(33.5f, -0.5f, 0);
                salad_s_.sortingOrder = 2;
                salad.sortingOrder = 2;
                break;
            case 8:
                ketchup_s.transform.Translate(12.5f, -1, 0);
                ketchup_s_.sortingOrder = 1;
                ketchup.sortingOrder = 1;
                onion_s.transform.Translate(16, 0, 0);
                onion_s_.sortingOrder = 3;
                onion.sortingOrder = 3;
                cheese_s.transform.Translate(19.5f, 0.7f, 0);
                cheese_s_.sortingOrder = 5;
                cheese.sortingOrder = 5;
                paprika_s.transform.Translate(23, 1, 0);
                paprika_s_.sortingOrder = 6;
                paprika.sortingOrder = 6;
                meat_s.transform.Translate(26.5f, 0.5f, 0);
                meat_s_.sortingOrder = 4;
                meat.sortingOrder = 4;
                cucumber_s.transform.Translate(30, 1.5f, 0);
                cucumber_s_.sortingOrder = 7;
                cucumber.sortingOrder = 7;
                salad_s.transform.Translate(33.5f, -0.5f, 0);
                salad_s_.sortingOrder = 2;
                salad.sortingOrder = 2;
                break;


        }
    }
}

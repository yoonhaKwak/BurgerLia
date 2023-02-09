using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sampleController1 : MonoBehaviour
{
    public GameObject topBun_s;
    public GameObject ketchup_s;
    public GameObject cheese_s;
    public GameObject paprika_s;
    public GameObject chicken_s;
    public GameObject salad_s;
    public GameObject bottomBun_s;
    public int random;
    public SpriteRenderer topBun_s_;
    public SpriteRenderer ketchup_s_;
    public SpriteRenderer cheese_s_;
    public SpriteRenderer paprika_s_;
    public SpriteRenderer chicken_s_;
    public SpriteRenderer salad_s_;
    public SpriteRenderer bottomBun_s_;

    public SpriteRenderer topBun;
    public SpriteRenderer ketchup;
    public SpriteRenderer cheese;
    public SpriteRenderer paprika;
    public SpriteRenderer chicken;
    public SpriteRenderer salad;
    public SpriteRenderer bottomBun;
    // Start is called before the first frame update
    void Start()
    {
        this.topBun_s = GameObject.Find("topBun_s");
        this.ketchup_s = GameObject.Find("ketchup_s");
        this.cheese_s = GameObject.Find("cheese_s");
        this.paprika_s = GameObject.Find("paprika_s");
        this.chicken_s = GameObject.Find("chicken_s");
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
        random = Random.Range(0, 6);
        topBun_s.transform.Translate(30, 2.3f, 0);
        bottomBun_s.transform.Translate(9, -2, 0);

        switch (random)
        {
            case 0:
                ketchup_s.transform.Translate(26.5f, 2, 0);
                ketchup_s_.sortingOrder = 5;
                ketchup.sortingOrder = 5;
                cheese_s.transform.Translate(23, 1.5f, 0);
                cheese_s_.sortingOrder = 4;
                cheese.sortingOrder = 4;
                paprika_s.transform.Translate(19.5f, 1, 0);
                paprika_s_.sortingOrder = 3;
                paprika.sortingOrder = 3;
                chicken_s.transform.Translate(16, 0, 0);
                chicken_s_.sortingOrder = 2;
                chicken.sortingOrder = 2;
                salad_s.transform.Translate(12.5f, -1, 0);
                salad_s_.sortingOrder = 1;
                salad.sortingOrder = 1;
                break;
            case 1:
                ketchup_s.transform.Translate(26.5f, 0, 0);
                ketchup_s_.sortingOrder = 2;
                ketchup.sortingOrder = 2;
                cheese_s.transform.Translate(23, 2, 0);
                cheese_s_.sortingOrder = 5;
                cheese.sortingOrder = 5;
                paprika_s.transform.Translate(19.5f, -1, 0);
                paprika_s_.sortingOrder = 1;
                paprika.sortingOrder = 1;
                chicken_s.transform.Translate(16, 1 , 0);
                chicken_s_.sortingOrder = 3;
                chicken.sortingOrder = 3;
                salad_s.transform.Translate(12.5f, 1.5f, 0);
                salad_s_.sortingOrder = 4;
                salad.sortingOrder = 4;
                break;
            case 2:
                ketchup_s.transform.Translate(26.5f, 0, 0);
                ketchup_s_.sortingOrder = 2;
                ketchup.sortingOrder = 2;
                cheese_s.transform.Translate(23, -1, 0);
                cheese_s_.sortingOrder = 1;
                cheese.sortingOrder = 1;
                paprika_s.transform.Translate(19.5f, 2, 0);
                paprika_s_.sortingOrder = 5;
                paprika.sortingOrder = 5;
                chicken_s.transform.Translate(16, 1.5f, 0);
                chicken_s_.sortingOrder = 4;
                chicken.sortingOrder = 4;
                salad_s.transform.Translate(12.5f, 1, 0);
                salad_s_.sortingOrder = 3;
                salad.sortingOrder = 3;
                break;
            case 3:
                ketchup_s.transform.Translate(26.5f, 1, 0);
                ketchup_s_.sortingOrder = 3;
                ketchup.sortingOrder = 3;
                cheese_s.transform.Translate(23, 0, 0);
                cheese_s_.sortingOrder = 2;
                cheese.sortingOrder = 2;
                paprika_s.transform.Translate(19.5f, -1, 0);
                paprika_s_.sortingOrder = 1;
                paprika.sortingOrder = 1;
                chicken_s.transform.Translate(16, 2, 0);
                chicken_s_.sortingOrder = 5;
                chicken.sortingOrder = 5;
                salad_s.transform.Translate(12.5f, 1.5f, 0);
                salad_s_.sortingOrder = 4;
                salad.sortingOrder = 4;
                break;
            case 4:
                ketchup_s.transform.Translate(26.5f, 1.5f, 0);
                ketchup_s_.sortingOrder = 4;
                ketchup.sortingOrder = 4;
                cheese_s.transform.Translate(23, -1, 0);
                cheese_s_.sortingOrder = 1;
                cheese.sortingOrder = 1;
                paprika_s.transform.Translate(19.5f, 1, 0);
                paprika_s_.sortingOrder = 3;
                paprika.sortingOrder = 3;
                chicken_s.transform.Translate(16, 0, 0);
                chicken_s_.sortingOrder = 2;
                chicken.sortingOrder = 2;
                salad_s.transform.Translate(12.5f, 2, 0);
                salad_s_.sortingOrder = 5;
                salad.sortingOrder = 5;
                break;
            case 5:
                ketchup_s.transform.Translate(26.5f, 0, 0);
                ketchup_s_.sortingOrder = 2;
                ketchup.sortingOrder = 2;
                cheese_s.transform.Translate(23, 1.5f, 0);
                cheese_s_.sortingOrder = 4;
                cheese.sortingOrder = 4;
                paprika_s.transform.Translate(19.5f, 2, 0);
                paprika_s_.sortingOrder = 5;
                paprika.sortingOrder = 5;
                chicken_s.transform.Translate(16, -1, 0);
                chicken_s_.sortingOrder = 1;
                chicken.sortingOrder = 1;
                salad_s.transform.Translate(12.5f, 1, 0);
                salad_s_.sortingOrder = 3;
                salad.sortingOrder = 3;
                break;

        }
    }
}

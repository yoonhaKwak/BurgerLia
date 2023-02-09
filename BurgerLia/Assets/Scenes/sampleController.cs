using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sampleController : MonoBehaviour
{
    public GameObject topBun_s;
    public GameObject egg_s;
    public GameObject tomato_s;
    public GameObject meat_s;
    public GameObject bottomBun_s;
    public int random;
    public SpriteRenderer topBun_s_;
    public SpriteRenderer egg_s_;
    public SpriteRenderer tomato_s_;
    public SpriteRenderer meat_s_;
    public SpriteRenderer bottomBun_s_;

    public SpriteRenderer topBun;
    public SpriteRenderer egg;
    public SpriteRenderer tomato;
    public SpriteRenderer meat;
    public SpriteRenderer bottomBun;

    // Start is called before the first frame update
    public void Start()
    {
        this.topBun_s = GameObject.Find("topBun_s");
        this.egg_s = GameObject.Find("egg_s");
        this.tomato_s = GameObject.Find("tomato_s");
        this.meat_s = GameObject.Find("meat_s");
        this.bottomBun_s = GameObject.Find("bottomBun_s");

        sampleBurger();

    }

    // Update is called once per frame
    void Update()
    {        
        


    }
    public void sampleBurger()
    {
        random = Random.Range(0, 3);
        topBun_s.transform.Translate(26, 3, 0);
        bottomBun_s.transform.Translate(10, -2, 0);

        switch (random)
        {
            case 0:
                egg_s.transform.Translate(22, 2, 0);
                egg_s_.sortingOrder = 3;
                egg.sortingOrder = 3;
                tomato_s.transform.Translate(18, 1, 0);
                tomato_s_.sortingOrder = 2;
                tomato.sortingOrder = 2;
                meat_s.transform.Translate(14, 0, 0);
                meat_s_.sortingOrder = 1;
                meat.sortingOrder = 1;
                break;
            case 1:
                egg_s.transform.Translate(22, 1, 0);
                egg_s_.sortingOrder = 2;
                egg.sortingOrder = 2;
                tomato_s.transform.Translate(18, 0, 0);
                tomato_s_.sortingOrder = 1;
                tomato.sortingOrder = 1;
                meat_s.transform.Translate(14, 2, 0);
                meat_s_.sortingOrder = 3;
                meat.sortingOrder = 3;
                break;
            case 2:
                egg_s.transform.Translate(22, 0, 0);
                egg_s_.sortingOrder = 1;
                egg.sortingOrder = 1;
                tomato_s.transform.Translate(18, 2, 0);
                tomato_s_.sortingOrder = 3;
                tomato.sortingOrder = 3;
                meat_s.transform.Translate(14, 1, 0);
                meat_s_.sortingOrder = 2;
                meat.sortingOrder = 2;
                break;
        }
    }
}

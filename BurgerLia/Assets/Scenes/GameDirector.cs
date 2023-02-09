using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject topBun;
    GameObject tomato;
    GameObject egg;
    GameObject meat;
    GameObject bottomBun;

    // Start is called before the first frame update
    void Start()
    {
        this.topBun = GameObject.Find("topBun");
        this.tomato = GameObject.Find("tomato");
        this.egg = GameObject.Find("egg");
        this.meat= GameObject.Find("meat");
        this.bottomBun= GameObject.Find("bottomBun");

    }

    // Update is called once per frame
    void Update()
    {

    }

}

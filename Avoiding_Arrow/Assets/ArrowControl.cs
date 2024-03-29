﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowControl : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject player;
    void Start()
    {
        this.player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-0.1f,0,0);

        if(transform.position.x < -14.0f)
        {
            Destroy(gameObject);
        }

        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 0.5f;

        if(d < r1 + r2)
        {
            Destroy(gameObject);
        

        GameObject director = GameObject.Find("Director");
        director.GetComponent<GameDirector>().DecreaseHp();
        }
    }
}

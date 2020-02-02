﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyEvent : MonoBehaviour
{

    private CameraController cameraFollow;
    private Transform transform;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player") {
            cameraFollow.Setup(() => (new Vector2(transform.position.x + 10, transform.position.y)));
        }
    }
}

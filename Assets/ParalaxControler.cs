using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParalaxControler : MonoBehaviour
{

    public Transform player;

    //public float speed;

    private Vector2 lastPosition;

    // Start is called before the first frame update
    void Start()
    {
        this.lastPosition = player.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x +
            0.6f * (player.position.x - lastPosition.x), transform.position.y );
        this.lastPosition = player.position;
    }
}
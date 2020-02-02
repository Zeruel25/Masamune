using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlayer : MonoBehaviour
{
    public Transform player;

    public Transform spawnPoint;

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
        Debug.Log("Collision");
        if (collision.transform.tag == "Player") {
            Debug.Log("Player");
            player.position = spawnPoint.position;
        }
    }
}

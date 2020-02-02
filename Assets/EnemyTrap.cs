using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTrap : MonoBehaviour
{

    public Transform enemy;

    public Transform player;

    void Start() {
        this.transform.position = new Vector3(35, 10);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.transform.CompareTag("Player"))
        {
            enemy.position = new Vector3(player.transform.position.x - 10,
              player.transform.position.y, player.transform.position.z);
            this.transform.position = new Vector2(-20, -20);
        }
    }
}

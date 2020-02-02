using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAtack : MonoBehaviour
{

    [SerializeField] Transform spawnPoint;

    public Transform player;

    public Transform enemyEvent;

    public Vector2 lastPost;

    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = new Vector2(-52, -8.16f);
        lastPost = transform.position;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.transform.CompareTag("Player"))
        {
            collision.transform.position = spawnPoint.position;
            this.transform.position = lastPost;
            enemyEvent.position =  new Vector3(35, 10);

        }
    }

}

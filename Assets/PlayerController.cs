using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocityX;
    public float jumpForce;
    private Rigidbody2D rb2d;
    public bool canJump;
    public Transform spawnerDisparos;
    public List<GameObject> proyectiles;


    Animator animator;
    Vector3 initialPosition;


    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        initialPosition = gameObject.transform.position;
        canJump = true;
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        var force = new Vector2(velocityX, 0);
        if (Input.GetKeyDown("space") && canJump) {
            force = new Vector2(force.x, jumpForce);
            canJump = false;
            Debug.Log("espacio");
            animator.SetBool("jumping", !canJump);
        }
        gameObject.GetComponent<Rigidbody2D>().AddForce(force);

        if (Input.GetKeyDown(KeyCode.Q)) {
            Disparar(proyectiles[0]);
        }
        if (Input.GetKeyDown(KeyCode.W)) {
            Disparar(proyectiles[1]);
        }
        if (Input.GetKeyDown(KeyCode.E)) {
            Disparar(proyectiles[2]);
        }
    }



    private void OnCollisionEnter2D(Collision2D collision) { 
        if (collision.transform.tag == "ground") {
            canJump = true;
            animator.SetBool("jumping", !canJump);
        }
    }

    void Disparar(GameObject proyectil) {
        GameObject bullet = Instantiate(proyectil, spawnerDisparos.position, Quaternion.identity);
       //  proy.GetComponent<Rigidbody2D>().AddForce(new Vector2(velocityX*5, 0f));
        // proy.GetComponent<Rigidbody2D>().velocity = transform.TransformDirection(Vector3.forward * 10);
        bullet.GetComponent<Rigidbody2D>().AddForce(transform.forward * 10);
        Destroy(bullet,5f);
    }
}


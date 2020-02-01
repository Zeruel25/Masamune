using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public float initialPositionY;

    void Start()
    {
        initialPositionY = gameObject.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3(player.transform.position.x +5, player.transform.position.y, gameObject.transform.position.z);
    }
}

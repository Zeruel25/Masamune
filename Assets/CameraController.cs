using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public float initialPositionY;
    public Func<Vector3> GetCameraFollow;
    public bool isSettup = false;
    void Start()
    {
        initialPositionY = gameObject.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (isSettup) {
            isSettup = false;
            Vector3 cameraFollow = GetCameraFollow();
            cameraFollow.z = transform.position.z;
            transform.position = cameraFollow;
            return;
        }
        gameObject.transform.position = new Vector3(player.transform.position.x +5, transform.position.y, gameObject.transform.position.z);
    }



   public void Setup(Func<Vector3> GetCameraFollow)
    {
        this.GetCameraFollow = GetCameraFollow;
        isSettup = true;
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{

    public Func<Vector3> GetCameraFollow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Setup(Func<Vector3> GetCameraFollow) {
        this.GetCameraFollow = GetCameraFollow;
    }
}

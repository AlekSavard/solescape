﻿using UnityEngine;
using System.Collections;

public class Radar : MonoBehaviour {


    float spinRotation = 0;

    float startTime;
    float lifeTime = 4; //how long to exist

    void Start()
    {
        startTime = Time.time;
        

    }

    void Update()
    {
        transform.localPosition = new Vector3(0, 0, Camera.main.transform.localPosition.x / 60f);
        transform.LookAt(transform.position + Camera.main.transform.rotation * Vector3.back,
        Camera.main.transform.rotation * Vector3.up);
        transform.Rotate(90, 0, 0);

        spinRotation += Time.deltaTime * 200 % 360;

        transform.Rotate(0, spinRotation, 0);
        
        float duration = Time.time - startTime;

        if (duration > lifeTime)
        {
            Destroy(this.gameObject);
        }


    }
}

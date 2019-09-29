﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
     offset = gameObject.transform.position;
     
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = player.transform.position + offset;
       
    }
}

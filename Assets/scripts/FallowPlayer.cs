﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3  offset;

    void Update()
    {
    
           //Debug.Log(player.position); 
           transform.position = player.position + offset;
    }
}

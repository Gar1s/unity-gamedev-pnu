using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{

    public float rotationSpeed = 5;


    void FixedUpdate()
    {
        transform.Rotate(new Vector3(0, 45, 0) * Time.deltaTime * rotationSpeed);
    }


}
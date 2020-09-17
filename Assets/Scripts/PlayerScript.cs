using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] private GameObject target;
    [SerializeField] private float speed;

    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position,target.transform.position, speed);
    }
}

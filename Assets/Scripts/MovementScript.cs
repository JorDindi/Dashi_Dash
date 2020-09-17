using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class MovementScript : MonoBehaviour
{
    [Header("Speed Variables")]
    [SerializeField] private float speed; 
    [SerializeField] private float jumpSpeed;
    [Header("Boolean")]
    public bool isGrounded, isAired, canDash, isDashing;
    [Header("Physics")]
    [SerializeField] private Rigidbody rb;
    [Header("Power Variables")]
    [SerializeField] private float DashForce;

    

    private void Start()
    {
        isAired = false;
    }


    private void Update()
    {
        transform.position += transform.forward * (speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }

        if (Input.GetKeyDown(KeyCode.D) && isAired && canDash)
        {
            Dash();
        }



    }

    public void Dash()
    {
        if (isAired && canDash)
        {
            rb.AddForce(Vector3.forward * DashForce, ForceMode.Impulse);
            canDash = false;
            isDashing = true;
        }

    }

    public void Jump()
    {
        if (isGrounded)
        {
            rb.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
            isGrounded = !isGrounded;
            isAired = true;
            canDash = true;
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Floor"))
        {
            isGrounded = true;
            isAired = false;
            isDashing = false;
        }

        if (other.CompareTag("FinishLine"))
        {
            
        }
    }
}

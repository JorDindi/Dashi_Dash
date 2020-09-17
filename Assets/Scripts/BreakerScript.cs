using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakerScript : MonoBehaviour
{
    
    [SerializeField] private float SeperatePower,TorquePower;
    [SerializeField] private Rigidbody lrb,rrb;
    public ScoreManager sm;
    [SerializeField] private MovementScript player;
    
    private void Start()
    {
        lrb.useGravity = false;
        rrb.useGravity = false;
    }

    private void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag("Player"))
        {
            if (player.isDashing)
            {
                sm.wallsBroke++;
                lrb.useGravity = true;
                rrb.useGravity = true;

                lrb.AddForce(-Vector3.right * SeperatePower);
                rrb.AddForce(Vector3.right * SeperatePower);
                lrb.AddTorque(Vector3.right * TorquePower);
                rrb.AddTorque(Vector3.right * TorquePower);
            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLineScript : MonoBehaviour
{

    [SerializeField] private ScoreManager scoreManager;
    [SerializeField] private Animator anim;
    
    


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && scoreManager.wallsBroke >= scoreManager.neededWalls)     
        {
            anim.SetTrigger("DisplayNext");
        }
    }
}

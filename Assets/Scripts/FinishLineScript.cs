using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLineScript : MonoBehaviour
{

    [SerializeField] private ScoreManager scoreManager;
    [SerializeField] private Animator anim;
    
    


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag.Equals("Player") && (scoreManager.wallsBroke >= scoreManager.neededWalls))     
        {
            anim.SetTrigger("DisplayNext");
        }
    }
}

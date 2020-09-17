using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private Text scoreDisplay;
    public int neededWalls;
    public float wallsBroke;
    


    private void Update()
    {
        scoreDisplay.text = wallsBroke.ToString() + " / " + neededWalls.ToString();
    }
    
}

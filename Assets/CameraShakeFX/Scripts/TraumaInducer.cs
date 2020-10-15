using System;
using UnityEngine;
using System.Collections;


public class TraumaInducer : MonoBehaviour 
{
    public float MaximumStress = 0.6f;
    public float Range = 45;
    
    
    private void Update()
    {

        var targets = UnityEngine.Object.FindObjectsOfType<GameObject>();
        for(int i = 0; i < targets.Length; ++i)
        {
            var receiver = targets[i].GetComponent<StressReceiver>();
            if(receiver == null) continue;
            float distance = Vector3.Distance(transform.position, targets[i].transform.position);
            /* Apply stress to the object, adjusted for the distance */
            if(distance > Range) continue;
            float distance01 = Mathf.Clamp01(distance / Range);
            float stress = (1 - Mathf.Pow(distance01, 2)) * MaximumStress;
            receiver.InduceStress(stress);
        }
    }

    public void PlayParticles()
    {
        var children = transform.GetComponentsInChildren<ParticleSystem>();
        for(var i  = 0; i < children.Length; ++i)
        {
            children[i].Play();
        }
        var current = GetComponent<ParticleSystem>();
        if(current != null) current.Play();
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    
    List <GameObject> currentCollisions = new List <GameObject> ();
    public GameObject chest;
    private ChestOpen chestOpen;
    
    void Start()
    {
        chestOpen = chest.GetComponent<ChestOpen>();
    }

    void OnCollisionEnter(Collision c)
    {
        currentCollisions.Add(c.gameObject);
        SetChestStatus();
    }
    
    void OnCollisionExit(Collision c)
    {
        currentCollisions.Remove(c.gameObject);
        SetChestStatus();
    }
    
    private float CheckWeight()
    {
        float totalWeight = 0;
        foreach (GameObject gObject in currentCollisions) {
            totalWeight += gObject.GetComponent<ObjectProperties>().GetWeight();
        }   
        return totalWeight;
    }
    
    private void SetChestStatus()
    {
        float totalWeight = CheckWeight();
        Debug.Log("Total weight: " + totalWeight);
        Debug.Log(chest);
        if (totalWeight > 10) chestOpen.OpenLid(true);
        else chestOpen.OpenLid(false);
    }
}

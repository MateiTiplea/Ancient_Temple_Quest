using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FloorCollider : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    void OnCollisionEnter(Collision c)
    {
        if(c.gameObject.tag == "floor")
        {
            Debug.Log("Ball hit the floor");
            transform.position = new Vector3(-18.66f, 20.68f, 1.15f);
            
        }
    }
}

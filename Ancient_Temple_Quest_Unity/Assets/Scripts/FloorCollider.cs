using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FloorCollider : MonoBehaviour
{

    public GameObject hieroglyphStone;

    
    void OnCollisionEnter(Collision c)
    {
        if(c.gameObject.CompareTag("floor"))
        {
            Debug.Log("Ball hit the floor");
            
            Transform stoneTransform = hieroglyphStone.transform;
            Transform currentTransform = transform;
            var ballPosition = currentTransform.position;
            var hieroglyphPosition = stoneTransform.position;
            currentTransform.position = new Vector3(hieroglyphPosition.x, hieroglyphPosition.y, hieroglyphPosition.z);
            stoneTransform.position = new Vector3(ballPosition.x, ballPosition.y, ballPosition.z);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectProperties : MonoBehaviour
{
    [SerializeField] Weight weight;
    
    public float GetWeight()
    {
        return weight.weight;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Weight", menuName = "ScriptableObjects/Weight", order = 1)]
public class Weight : ScriptableObject
{
    [Range(1, 100)]
    [Tooltip("The weight of the object")]
    public float weight = 1f;
}

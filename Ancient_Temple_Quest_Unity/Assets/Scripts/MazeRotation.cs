using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MazeRotation : MonoBehaviour
{
    public void rotateLeft()
    {
        // rotate the current object 5 degrees to the left
        transform.Rotate(0, -10, 0);
    }

    public void rotateRight()
    {
        // rotate the current object 5 degrees to the right
        transform.Rotate(0, 10, 0);
    }
}

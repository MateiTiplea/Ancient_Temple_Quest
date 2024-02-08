using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DoorOpen : MonoBehaviour
{
    private List<GameObject> doors;
    // Start is called before the first frame update
    void Start()
    {
        doors = new List<GameObject>();
        for (int i = 0; i < transform.childCount; i++)
        {
            doors.Add(transform.GetChild(i).gameObject);
        }
    }

    public void OpenDoors()
    {
        doors[0].transform.Rotate(0, 0, 28);
        doors[1].transform.Rotate(0, 0, 28);
    }

}

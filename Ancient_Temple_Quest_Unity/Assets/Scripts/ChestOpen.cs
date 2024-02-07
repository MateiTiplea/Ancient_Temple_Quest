using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestOpen : MonoBehaviour
{
    private GameObject lid;
    
    void Start()
    {
        lid = transform.GetChild(1).gameObject;
    }
    
    public void OpenLid(bool active)
    {
        if (active) Open();
        else Close();
    }    
    
    private void Open()
    {
        lid.transform.Rotate(45, 0, 0);
        Debug.Log("Open");
    }
    
    private void Close()
    {
        lid.transform.Rotate(-45, 0, 0);
        Debug.Log("Close");
    }
}

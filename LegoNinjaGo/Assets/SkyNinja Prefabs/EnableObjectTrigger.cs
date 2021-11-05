using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableObjectTrigger : MonoBehaviour
{
    public GameObject[] TargetObjects;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if (other.name == "Kai")
            EnableObject();
            
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.name);
        if (other.name == "Kai")
            DisableObject();

    }
    private void EnableObject()
    {
        Debug.Log("EnableObjects");
        for (int i = 0; i < TargetObjects.Length; i++)
            TargetObjects[i].SetActive(true);
    }

    private void DisableObject()
    {
        Debug.Log("DisableObjects");
        for (int i = 0; i < TargetObjects.Length; i++)
            TargetObjects[i].SetActive(false);
    }
}

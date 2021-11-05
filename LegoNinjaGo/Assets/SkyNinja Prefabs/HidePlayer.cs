using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HidePlayer : MonoBehaviour
{
    public GameObject kaiStanding;
    public GameObject kaiRunning;
    public GameObject speechBuuble;
    public float speachBubblewaitTime = 0; //6
    public float waitTime = 0;
    void Start()
    {
        StartCoroutine("UnhidePlayer");
    }

   IEnumerator UnhidePlayer()
    {
        yield return new WaitForSeconds(speachBubblewaitTime);
        speechBuuble.SetActive(true);
        yield return new WaitForSeconds(waitTime);
        kaiStanding.SetActive(false);
        kaiRunning.SetActive(true);
    }
}

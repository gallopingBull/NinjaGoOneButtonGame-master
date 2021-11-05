using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrigger : MonoBehaviour
{
    public int CameraID = 0;
    public GameObject WinSceneGameObjects;
    public GameObject Player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Kai")
        {
            CameraManager.instance.SwitchCamera(CameraID);
            if (CameraID == 1)
            {
                WinSceneGameObjects.SetActive(true);
                Player.SetActive(false);

            }
        }
    }
}

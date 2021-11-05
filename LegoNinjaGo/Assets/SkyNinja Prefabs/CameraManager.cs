using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public static CameraManager instance; 
    public CinemachineVirtualCamera[] cameras;
    public CinemachineBrain brain;

    private int currentCameraID = 0;

    void Awake()
    {
        if (instance == null)
            instance = this; 
    }

    public void SwitchCamera(int targetCameraID)
    {
        if (targetCameraID == 2 || targetCameraID == 0)
        {
            brain.m_DefaultBlend.m_Style = CinemachineBlendDefinition.Style.EaseIn;
        }
        else
        {
            brain.m_DefaultBlend.m_Style = CinemachineBlendDefinition.Style.Cut;
        }
        cameras[currentCameraID].Priority = 0;
        cameras[targetCameraID].Priority = 5;
        currentCameraID = targetCameraID;

       
    }
}

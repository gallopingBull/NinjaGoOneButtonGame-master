using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ModifyWebGLMemorySize : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerSettings.WebGL.memorySize = 1024;
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BVack : MonoBehaviour
{
    
    public GameObject myCanvas;
    public void ChangeScene()
    {
        Instantiate(myCanvas);
    }
}

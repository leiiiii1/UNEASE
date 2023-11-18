using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ComingSoon : MonoBehaviour
{

    public void ChangeScene()
    {
        SceneManager.LoadScene("DontOpen");
    }
}


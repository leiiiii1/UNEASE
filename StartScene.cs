using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScene : MonoBehaviour
{
    public GameObject gameObject2;
    
    public void Hide()
    {
        gameObject2.SetActive(false);
    }

}

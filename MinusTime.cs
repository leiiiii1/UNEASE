using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems; // Required when using Event data.

public class MinusTime : MonoBehaviour // required interface when using the OnPointerDown method.
{
    public bool lessTime = false;

    public bool lesstime()
    {
        BoxCollider2D myCollider = GetComponent<BoxCollider2D>();
        if (myCollider.OverlapPoint(Camera.main.ScreenToWorldPoint(Input.mousePosition)))
        {
            return OnMouseDown();
        }
        else
        {
            return false;
        }
        return false;
    }
    
    public bool OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            return true;
        }
        return false;
    }
}
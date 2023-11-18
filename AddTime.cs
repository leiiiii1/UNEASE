using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems; // Required when using Event data.

public class AddTime : MonoBehaviour // required interface when using the OnPointerDown method.
{
    public bool moretime = false;
    public int de = 0;

    public bool moreTime()
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
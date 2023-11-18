
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSubscriber : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        TestingEvents testingEvents = GetComponent<TestingEvents>();
        testingEvents.onClickStart += TestingEvents_onClickStart;
    }
    private void TestingEvents_onClickStart (object sender, EventArgs e)
    {
        Debug.Log("Clicked!");
    }

}

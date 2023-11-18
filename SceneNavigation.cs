using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SceneNavigation : MonoBehaviour
{
    public GameObject song1;
    public GameObject song2;
    public GameObject song3;
    public GameObject temp;
    public bool Click;
    public void BtnShowNext()
    {
        TestingEvents testingEvents = GetComponent<TestingEvents>();
        testingEvents.onClickStart += TestingEvents_onClickStart;

        Button nextButton = GetComponent <Button> ();

        if (Click = true)
        {
            song1.gameObject.SetActive(false);
            song2.gameObject.SetActive(true);
            temp = song1;
            song1 = song2;
            song2 = song3;
            song3 = temp;
            temp = null;
        }

    }

    public void BtnShowBack()
    {
        temp = song1;
        song1 = song2;
        song2 = song3;
        song3 = temp;
        temp = null;
        song1.gameObject.SetActive(false);
        song2.gameObject.SetActive(true);
    }

    private void TestingEvents_onClickStart(object sender, EventArgs e)
    {
        Click = true;
    }
}
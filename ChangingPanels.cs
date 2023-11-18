using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingPanels : MonoBehaviour
{
    public GameObject currentPanel;
    public GameObject nextPanel;

    public void switchPanel()
    {
        currentPanel.SetActive(false);
        nextPanel.SetActive(true);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChangeText : MonoBehaviour
{

    public TextMeshProUGUI studentName;
    public TextMeshProUGUI noSubmission;

    public bool submittedProject;

    // Start is called before the first frame update
    void Start()
    {
        studentName.enabled = false;
        noSubmission.enabled = false;
    }

    public void HoverStart()
    {
        studentName.enabled = true;

        if(submittedProject == false)
        {
            noSubmission.enabled = true;
        }
        else
        {
            noSubmission.enabled = false;
        }
    }

    public void HoverExit()
    {
        studentName.enabled = false;
        noSubmission.enabled = false;
    }
}

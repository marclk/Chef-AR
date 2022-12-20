using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleStepByStep : MonoBehaviour
{

    public GameObject stepCanvas;

    // Awake is called before Start
    void Awake()
    {
        stepCanvas = GameObject.FindWithTag("StepCanvas");
    }

    // Start is called before the first frame update
    void Start()
    {
        Toggle toggle = GetComponent<Toggle>();

        ToggleStepCanvas();

        toggle.onValueChanged.AddListener(delegate {ToggleStepCanvas();});
    }

    public void ToggleStepCanvas()
    {
        Debug.Log("CLICKED!!!!!!!!!!");

        if(!stepCanvas.activeSelf){         // if stepCanvas is not active
            stepCanvas.SetActive(true);
        }else{                              // if stepCanvas is active
            stepCanvas.SetActive(false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleDetailViewChicken : MonoBehaviour
{
    public GameObject detailCanvas;

    // Start is called before the first frame update
    void Start()
    {
        Toggle toggle = GetComponent<Toggle>();

        detailCanvas = GameObject.FindWithTag("DCChicken");


        toggle.onValueChanged.AddListener(delegate { Foo(); });
    }

    public void Foo()
    {
        if (!detailCanvas.activeSelf)
        {   // if detailCanvas is not active
            detailCanvas.SetActive(true);
        }
        else
        {                          // if detailCanvas is active
            detailCanvas.SetActive(false);
        }
    }
}


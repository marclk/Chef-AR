using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleDetailView : MonoBehaviour
{

    public GameObject detailCanvas;

    // Start is called before the first frame update
    void Awake()
    {
        detailCanvas = GameObject.FindWithTag("DetailCanvas");
    }
    
    void Start()
    {
        Toggle toggle =  GetComponent<Toggle>();

        ToggleDetail();

        toggle.onValueChanged.AddListener(delegate {ToggleDetail();});
    }

    public void ToggleDetail()
    {
        if(!detailCanvas.activeSelf){   // if detailCanvas is not active
            detailCanvas.SetActive(true);
        }else{                          // if detailCanvas is active
            detailCanvas.SetActive(false);
        }
    }
}

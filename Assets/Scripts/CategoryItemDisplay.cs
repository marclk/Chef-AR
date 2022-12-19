using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class CategoryItemDisplay : MonoBehaviour
{

    public CategoryItem item;

    public TMP_Text nameText;

    public Color color;

    // Start is called before the first frame update
    void Start()
    {
        nameText.text = item.name;

        color = item.color;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

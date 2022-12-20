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
    public TMP_Text nameTextSelected;

    public Image tagImageColor;
    public Image tagImageColorSelected;

    // Start is called before the first frame update
    void Start()
    {
        nameText.text = item.name;
        nameTextSelected.text = item.name;

        tagImageColor.color = item.color;
        tagImageColorSelected.color = item.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

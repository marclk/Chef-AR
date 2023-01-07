using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class StepByStepDisplay : MonoBehaviour
{

    public RecipeCard card;

    public Transform mainDisplay;
    public Transform detailDisplay;

    public TMP_Text titleText;

    public RawImage stepVideo;

    public TMP_Text stepDiscriptionText;

    public Transform ingredientsContainer;
    public GameObject ingredientPrefab;

    public Transform stepContainer;
    public GameObject stepPrefab;


    // Start is called before the first frame update
    void Start()
    {

    }

    public void setCard(RecipeCard recipe){
        card = recipe;
        updateStepView();
    }

    public void updateStepView(){
        // set main display and detail display off

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

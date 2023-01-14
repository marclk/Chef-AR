using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using System;
using DanielLochner.Assets.SimpleScrollSnap;

public class StepByStepDisplay : MonoBehaviour
{

    public RecipeCard card;

    public Transform mainDisplay;
    public Transform detailDisplay;

    public GameObject ingredientPrefab;

    public Transform stepContainer;
    public GameObject stepPrefab;

    public Transform toggleContainer;
    public ToggleGroup toggleGroup;
    public Toggle togglePrefab;

    public SimpleScrollSnap scrollSnap;

    private float toggleWidth;

    private bool isActive;

    // Awake is called before Start()
    void Awake()
    {
        toggleWidth = (togglePrefab.transform as RectTransform).sizeDelta.x * (Screen.width / 2048f);
        
    }

    // Start is called before the first frame update
    void Start()
    {
        isActive = false;
        gameObject.transform.localScale = new Vector3(0, 0, 0);
    }

    public void setCard(RecipeCard recipe){
        card = recipe;
        updateStepView();
    }

    public void updateStepView(){

        DestroyChildren(stepContainer);

        for (int i = 0; i < card.steps.Length; i++){
            AddToFront(card.steps[i], i);
        }

        scrollSnap.GoToPanel(scrollSnap.NumberOfPanels-1);
    }

    public void onToggleView(){
        if(!isActive){
            isActive = true;

            gameObject.transform.localScale = new Vector3(1,1,1);

            mainDisplay.gameObject.SetActive(!isActive);
            detailDisplay.gameObject.SetActive(!isActive);
        }else{
            isActive = false;

            gameObject.transform.localScale = new Vector3(0,0,0);

            mainDisplay.gameObject.SetActive(!isActive);
            detailDisplay.gameObject.SetActive(!isActive);
        }
    }

    // Remove Existing children from passed parent
    public void DestroyChildren(Transform parent){
		for (int i = parent.childCount - 1; i >= 0; i--){
			Remove(i);
		}
		parent.DetachChildren();
	}

    public void AddToBack(StepObject step, int num){
        Add(scrollSnap.NumberOfPanels, step, num);
    }

    public void AddToFront(StepObject step, int num){
        Add(0, step, 0);
    }

    public void Add(int index, StepObject step, int num)
        {
            // Pagination
            Toggle toggle = Instantiate(togglePrefab, scrollSnap.Pagination.transform.position + new Vector3(toggleWidth * (scrollSnap.NumberOfPanels + 1), 0, 0), Quaternion.identity, scrollSnap.Pagination.transform);
            toggle.group = toggleGroup;
            scrollSnap.Pagination.transform.position -= new Vector3(toggleWidth / 2f, 0, 0);

            // Panel
            GameObject stepContent = stepPrefab;

            var stepTitle           = stepContent.transform.GetChild(0);
            var stepVideo           = stepContent.transform.GetChild(1);
            var stepDescription     = stepContent.transform.GetChild(3);

            stepTitle.GetComponent<TMP_Text>().text         = "Step " + (scrollSnap.NumberOfPanels+1); // veranderen naar 'Step X'
            stepVideo.GetComponent<RawImage>().texture      = step.stepVideo;
            stepDescription.GetComponent<TMP_Text>().text   = step.description;

            scrollSnap.Add(stepContent, index);

            stepVideo.GetComponent<Animation>().AddClip(step.animationClip, "videoAnimation");
            Debug.Log("animation: " + step.animationClip);
            Debug.Log("step: " + step);

            for(int i = 0; i < step.ingredients.Length; i++){

                Transform currentStep  = stepContainer.GetChild(num);
                var stepIngredientList  = currentStep.transform.GetChild(2);
                GameObject ingredient   = Instantiate(ingredientPrefab, stepIngredientList);

                var ingredientImage = ingredient.transform.GetChild(0);
                var ingredientAmount = ingredient.transform.GetChild(1);

                ingredientImage.GetComponent<RawImage>().texture    = step.ingredients[i].icon;
                ingredientAmount.GetComponent<TMP_Text>().text      = step.amountPerIngredient[i];

            }

        }

    public void Remove(int index)
        {
            if (scrollSnap.NumberOfPanels > 0)
            {
                // Pagination
                DestroyImmediate(scrollSnap.Pagination.transform.GetChild(scrollSnap.NumberOfPanels - 1).gameObject);
                scrollSnap.Pagination.transform.position += new Vector3(toggleWidth / 2f, 0, 0);

                // Panel
                Debug.Log("INDEX: " + index);
                Debug.Log("NumberOfPanels: " + scrollSnap.NumberOfPanels);
                scrollSnap.Remove(index);  
            }
        }
}

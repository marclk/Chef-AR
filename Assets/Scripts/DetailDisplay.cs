using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class DetailDisplay : MonoBehaviour
{

	public RecipeCard card;

	public TMP_Text nameText;
	public TMP_Text descriptionText;

	public Image coverImage;

	public TMP_Text prepTimeText;
	public TMP_Text cookTimeText;

	public TMP_Text difficultyText;

	public Transform ingredientsContainer;
	public GameObject ingredientPrefab;

	public Transform stepsContainer;
	public GameObject stepPrefab;

	// Start is called before the first frame update
	void Start()
	{
		updateDetail();
	}

	public void setCard(RecipeCard recipe){
		card = recipe;
		updateDetail();
	}

	public void updateDetail(){
		nameText.text = card.name;
		descriptionText.text = card.description;
		
		coverImage.sprite = card.coverImage;

		prepTimeText.text = card.prepTime.ToString();
		cookTimeText.text = card.cookTime.ToString();

		// difficultyText.text = card.difficulty;

		if(card.steps.Length != 0 || card.steps != null){
			for(int i = 0; i < card.steps.Length; i++){
				// iterate through the steps, and instantiate them in stepsContainer
				GameObject step = Instantiate(stepPrefab) as GameObject;
				var stepNum = step.transform.GetChild(0);
				var stepText = step.transform.GetChild(1);

				stepNum.GetComponent<TMP_Text>().text = "" + i+1;
				stepText.GetComponent<TMP_Text>().text = card.steps[i];

				step.transform.SetParent(stepsContainer);
			}
		}

		if(card.ingredients.Length != 0 || card.ingredients != null){
			for(int i = 0; i < card.ingredients.Length; i++){
				// iterate through the steps, and instantiate them in stepsContainer
				GameObject ingredient = Instantiate(ingredientPrefab) as GameObject;
				var ingredientText = ingredient.transform.GetChild(0);

				ingredientText.GetComponent<TMP_Text>().text = card.ingredients[i];
				
				ingredient.transform.SetParent(ingredientsContainer);

			}
		}
	}
}	

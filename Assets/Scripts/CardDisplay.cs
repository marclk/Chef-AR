using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class CardDisplay : MonoBehaviour
{

    public RecipeCard card;

    public TMP_Text nameText;

    public Image coverImage;

    public TMP_Text timeText;
    public TMP_Text difficultyText;

    public TMP_Text tagText;

    public Image tagColor;

    // Start is called before the first frame update
    void Start()
    {   
        // link card values to textfields
        nameText.text = card.name;

        coverImage.sprite = card.coverImage;

        timeText.text = (card.prepTime + card.cookTime).ToString() + " min";
        difficultyText.text = card.difficulty;

        tagText.text = card.tags[0].name;

        tagColor.color = card.tags[0].color;

        //Dynamic difficulty colors
        switch(card.difficulty.ToLower())
        {
            case "easy":
                difficultyText.color = new Color32(1, 170, 1, 255);
                break;
            case "moderate":
                difficultyText.color = new Color32(231, 152, 0, 255);
                break;
            case "hard":
                difficultyText.color = new Color32(202, 0, 0, 255);
                break;
        }

    }

    //Dynamically Link RecipeCard from resources folder to card
    public void setCard(RecipeCard recipe){
        card = recipe;
    }



}

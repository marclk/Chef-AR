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

    // Start is called before the first frame update
    void Start()
    {
        nameText.text = card.name;

        coverImage.sprite = card.coverImage;

        timeText.text = (card.prepTime + card.cookTime).ToString() + " min";
        difficultyText.text = card.difficulty;

        tagText.text = card.tags[0];
    }

}

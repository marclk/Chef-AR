using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecipeDetail : MonoBehaviour
{
    public GameObject recipeDetailView;
    
    // Awale is called before Start()
    void Awake()
    {
        recipeDetailView = GameObject.FindWithTag("RecipeDetail");
    }
    
    // Start is called before the first frame update
    void Start()
    {
        Button btn = GetComponent<Button>();

        btn.onClick.AddListener(delegate{OnButtonClick();});
    }

    public void OnButtonClick()
    {
        RecipeCard card = this.transform.parent.GetComponent<CardDisplay>().card;
        recipeDetailView.GetComponent<DetailDisplay>().setCard(card);
        
    }
}

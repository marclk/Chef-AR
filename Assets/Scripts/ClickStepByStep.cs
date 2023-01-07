using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickStepByStep : MonoBehaviour
{
   public GameObject recipeStepView;
    
    // Awake is called before Start()
    void Awake()
    {
        recipeStepView = GameObject.FindWithTag("RecipeStepByStep");
    }
    
    // Start is called before the first frame update
    void Start()
    {
        Button btn = GetComponent<Button>();

        btn.onClick.AddListener(delegate{OnButtonClick();});
    }

    public void OnButtonClick()
    {
        RecipeCard card = this.transform.parent.parent.GetComponent<DetailDisplay>().card;
        recipeStepView.GetComponent<StepByStepDisplay>().setCard(card);
        
    }
}

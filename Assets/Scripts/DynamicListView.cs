using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicListView : MonoBehaviour
{
 
    public GameObject listItemPrefab;
    public Transform listItemHolder;
    public int numOfListItems;

    private RecipeCard[] recipes;
    private GameObject[] allRecipeCards;

    private void Awake()
    {
        recipes = Resources.LoadAll<RecipeCard>("Recipes");

        for (int i = 0; i < recipes.Length; i++)
        {
            Instantiate(listItemPrefab, listItemHolder);
        }
    }

    private void Start() 
    {
        
        

        allRecipeCards = GameObject.FindGameObjectsWithTag("RecipeCard");

        int i = 0;
        foreach(var r in allRecipeCards)
        {
            r.GetComponent<CardDisplay>().card = recipes[i];
            
            if(i == recipes.Length){
                i = 0; 
            }else{
                i++;
            }
            
        }
    
    }
}

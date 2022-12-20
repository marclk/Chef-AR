using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicListView : MonoBehaviour
{
 
    public GameObject listItemPrefab;
    public Transform listItemHolder;

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

        InitList();
    
    }

    public void InitList(){

        allRecipeCards = GameObject.FindGameObjectsWithTag("RecipeCard");

        int i = 0;
        foreach(var r in allRecipeCards)
        {
            r.GetComponent<CardDisplay>().card = recipes[i];
            
            if(i == recipes.Length-1){
                i = 0; 
            }else{
                i++;
            }
            
        }
    }

    // public void UpdateList(actieveRecepten){

    // }
}

// Gebruiker klikt op een toggle button en ziet een gefilterde lijst met recepten:


// 1. onclick tag

// 3. gaat naar onTagToggle(tag)

// 4. onToggleTag neemt de tag waarde op, 
// 	Checkt of de tag waarde in ActieveRecepten[] staat, 
// 	a. Zo ja, 
// 	- haal de tag uit ActieveRecepten[]
// 	- zet de style van de toggle op deselected
// 	- call functie UpdateList(ActieveRecepten[])	

// 	b. Zo nee, 
// 	- voeg de tagwaarde in ActieveRecepten[] toe
// 	- zet de style van de toggle op selected
// 	- call functie UpdateList(ActieveRecepten[])

	
// 5. UpdateList(ActieveRecepten[])
// 	a. haal alle list items op in AlleRecepten
// 	b. Check of ActieveRecepten leeg is
// 		- zo wel, zet alle recepten op actief en return;
// 		- zo niet, ga door.
// 	C. for loop op alle list items
// 		- Check of de tag overeen komt met ActieveRecepten[]
// 			+Zo ja: setActive(true)
// 			+Zo niet: setActive (false)


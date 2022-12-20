using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleCategory : MonoBehaviour
{

    public CategoryItem catItem;
    public CategoryItem[] catItems;

    public GameObject parent;

    public bool isSelected;


    // Start is called before the first frame update
    void Start()
    {
        // initCategory();

        // Toggle toggle =  GetComponent<Toggle>();

        // parent = this.transform.parent;

        // catItem = parent.GetComponent<CategoryItemDisplay>().item;
        
        // toggle.onValueChanged.AddListener(delegate {onCategoryToggle();});
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void initCategory()
    {
        isSelected = false;
        
    }

    public void onCategoryToggle()
    {
        // if(!isSelected){        // if Not Selected, set to selected
        //     isSelected = true;
        //     parent.FindWithTag("selectedCatItem").setActive(true);
        //     parent.FindWithTag("unselectedCatItem").setActive(false);

        // }else{                  // if Selected, set to unselected
        //     isSelected = false;         
        //     parent.FindWithTag("selectedCatItem").setActive(false);
        //     parent.FindWithTag("unselectedCatItem").setActive(true);
        // }
    }
}

// Gebruiker klikt op een toggle button en ziet een gefilterde lijst met recepten:


// 1. onclick tag

// 3. gaat naar onTagToggle(tag) x

// 4. onToggleTag neemt de tag waarde op, 
// 	Checkt of de tag waarde in AlleRecepten[] staat, 
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


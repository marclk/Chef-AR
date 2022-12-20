using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicTagView : MonoBehaviour
{

     public GameObject listItemPrefab;
     public Transform listItemHolder;

     private CategoryItem[] categories;
     private GameObject[] allCategoryItems;

    
    private void Awake()
    {
        categories = Resources.LoadAll<CategoryItem>("Categories");

        for (int i = 0; i < categories.Length; i++)
        {
            Instantiate(listItemPrefab, listItemHolder);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        allCategoryItems = GameObject.FindGameObjectsWithTag("CategoryItem");

        int i = 0;
        foreach(var r in allCategoryItems)
        {
            r.GetComponent<CategoryItemDisplay>().item = categories[i];

            if(i == categories.Length-1){
                i = 0;
            }else{
                i++;
            }
        }
    }
}

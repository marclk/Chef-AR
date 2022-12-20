using System.Collections;
using System.Collections.Generic;
using UnityEngine;



 [CreateAssetMenu(fileName = "RecipeCard", menuName = "Chef AR/RecipeCard", order = 0)]
public class RecipeCard : ScriptableObject {
    public new string name;
    public string description;

    public Sprite coverImage;

    public int prepTime;
    public int cookTime;

    public string difficulty;
    
    public string[] steps;
    public string[] ingredients;

    public CategoryItem[] tags;
}

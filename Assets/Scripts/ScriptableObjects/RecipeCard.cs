using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Recipe", menuName = "Chef AR/Recipe", order = 0)]
public class RecipeCard : ScriptableObject {
    public new string name;
    public string description;

    public Sprite coverImage;

    public int prepTime;
    public int cookTime;

    public string difficulty;
    
    public StepObject[] steps;

    public CategoryItem[] tags;
}

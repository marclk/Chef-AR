using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "IngredientObject", menuName = "Chef AR/IngredientObject", order = 0)]
public class IngredientObject : ScriptableObject {
    public new string name;

    public Sprite icon;
} 


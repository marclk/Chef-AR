using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
// using UnityEditor;


[CreateAssetMenu(fileName = "StepObject", menuName = "Chef AR/StepObject", order = 0)]
public class StepObject : ScriptableObject {
    public string title;

    public string description;

    public Sprite stepVideo;

    public IngredientObject[] ingredients; 

    public string[] amountPerIngredient;

    public RuntimeAnimatorController animController;

}

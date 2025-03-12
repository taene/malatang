using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "IngredientData", menuName = "Scriptable Object/IngredientData")]
public class IngredientData : ScriptableObject
{
    [SerializeField]
    private List<IngredientInfo> ingredientInfos = new List<IngredientInfo>();
}

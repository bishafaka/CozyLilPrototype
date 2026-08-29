using UnityEngine;

[CreateAssetMenu(fileName="Ingredient", menuName="Inventory/Ingredient")]
public class Ingredient : ScriptableObject
{
    public string ingredientName;
    public Sprite ingredientIcon;
    [TextArea(3, 6)]
    public string ingredientDescription;
}

using UnityEngine;

[CreateAssetMenu(fileName="Item", menuName="Inventory/Item")]
public class Item : Entry
{
    public Sprite itemIcon;
    public int itemPrice;
    public ItemType itemType;
    public ActionType actionType;
}
public enum ItemType
{
    Ingredient,
    Tool,
    Prep,
    Bake
}
public enum ActionType
{
    None,
    Mix,
    Churn,
    Oven,
    Fry,
    Wafer
}

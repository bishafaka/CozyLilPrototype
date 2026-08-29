using UnityEngine;

[CreateAssetMenu(fileName="Quest", menuName="Inventory/Quest")]
public class Quest : ScriptableObject
{
    public string questName;
    [TextArea(3, 6)]
    public string questDescription;
    public bool isQuestCompleted=false;
}

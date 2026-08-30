using UnityEngine;

[CreateAssetMenu(fileName="EntryObject", menuName="Scriptable Objects/EntryObject")]
public class Entry : ScriptableObject
{
    public string entryName;
    [TextArea(3, 6)]
    public string entryDescription;
}

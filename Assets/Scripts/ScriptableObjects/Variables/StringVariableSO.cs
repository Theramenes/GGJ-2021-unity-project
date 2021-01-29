using UnityEngine;


[CreateAssetMenu(menuName = "ScriptableObjects/Variables/String Variable", order = 3)]
public class StringVariableSO : ScriptableObject
{
    [SerializeField]
    private string value = "";

    public string Value
    {
        get { return value; }
        set { this.value = value; }
    }
}

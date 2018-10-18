using UnityEngine;


[CreateAssetMenu(fileName = "Bool", menuName = "Variables/Bool", order = 1)]
public class BoolVariable : ScriptableObject
{
    public bool Value;

    public void SetValue(bool value)
    {
        Value = value;
    }

    public void SetValue(BoolVariable value)
    {
        Value = value.Value;
    }

    public void ToggleValue()
    {
        Value =! Value;
    }
}

using UnityEngine;

[CreateAssetMenu]

public class IntData : ScriptableObject
{
    public int value;

    public void StartValue(int number)
    {
        value = number;
    }
    public void UpdateValue(int number)
    {
        value += number;
    }
}

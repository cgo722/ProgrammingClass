using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class GameAction : ScriptableObject
{
    public UnityAction action;

    void Raise()
    {
        action?.Invoke();
    }
}

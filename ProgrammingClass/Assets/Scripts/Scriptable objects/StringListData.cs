using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class StringListData : ScriptableObject
{
    public List<string> stringLists;
    private string returnValue;

    private int i;

    private void OnEnable()
    {
        i = 0;
    }
    public void getNextString()
    {
        returnValue = stringLists[i];
        i = (i+ 1) % stringLists.Count;
    }

    public void SetValueTextUIToValue(Text obj)
    {
        obj.text = returnValue;
    }

}

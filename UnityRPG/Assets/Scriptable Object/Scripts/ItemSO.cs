using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSO : ScriptableObject
{
    [field: SerializeField] public Sprite Icon;
    [field: SerializeField] public int Id;
    [field: SerializeField] public string Name;
    [field: SerializeField] [TextArea] public string Discription;
    [field: SerializeField] public int Stat;
    [field: SerializeField] public int Price;
}

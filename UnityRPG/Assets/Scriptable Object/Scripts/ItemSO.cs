using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSO : ScriptableObject
{
    public Sprite Icon;
    public int Id;
    public string Name;
    [TextArea] public string Discription;
     public bool CanStack;
     public int Stat;
     public int Price;
}

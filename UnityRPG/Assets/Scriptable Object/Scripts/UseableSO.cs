using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Useable", menuName = "Scriptable Object/Item/Useable")]
public class UseableSO : ItemSO
{
    [field: SerializeField] public int Count;
}

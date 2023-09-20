using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Armor", menuName = "Scriptable Object/Item/Armor")]
public class ArmorSO : ItemSO
{
    [field: SerializeField] public ArmorType Type;
}

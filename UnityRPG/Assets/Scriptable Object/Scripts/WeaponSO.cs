using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Weapon", menuName = "Scriptable Object/Item/Weapon")]
public class WeaponSO : ItemSO
{
    [field: SerializeField] public WeaponType Type;
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "StatSO", menuName = "Scriptable Object/StatSO")]
public class StatSO : ScriptableObject
{
    public PlayerType Type;
    public int MaxHP;
    public int MaxMP;
    public int Level;
    public int Atk;
    public int Def;
    // 크리티컬 찬스
    public float CC;
    // 크리티컬 데미지
    public float CD;
    // 닷지 찬스
    public float DC;
}

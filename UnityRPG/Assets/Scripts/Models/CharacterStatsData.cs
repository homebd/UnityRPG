using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CharacterStatsData
{
    public string Name { get; set; }
    public int MaxHP { get; set; }
    public int CurHP { get; set; }
    public int MaxMP { get; set; }
    public int CurMP { get; set; }
    public int Level { get; set; }
    public int Exp { get; set; }
    public int Gold { get; set; }
    public int Atk { get; set; }
    public int Def { get; set; }
    // 크리티컬 찬스
    public float CC { get; set; }
    // 크리티컬 데미지
    public float CD { get; set; }
    // 닷지 찬스
    public float DC { get; set; }

}

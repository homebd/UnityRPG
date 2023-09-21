using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStatsHandler : MonoBehaviour
{
    [SerializeField] private StatSO _baseStats;

    public CharacterStatsData CurStats { get; private set; }
    public List<CharacterStatsData> StatsModifiers = new List<CharacterStatsData>();

    private void Awake() {
        UpdateCharacterStatData();
    }

    private void UpdateCharacterStatData() {
        CurStats = new CharacterStatsData();

        // TODO: 기존 데이터와 베이스 데이터를 계산하여 입력
        CurStats.Type = _baseStats.Type;
        CurStats.Name = "스파르타";
        CurStats.MaxHP = _baseStats.MaxHP;
        CurStats.CurHP = CurStats.MaxHP;
        CurStats.MaxMP = _baseStats.MaxMP;
        CurStats.CurMP = CurStats.MaxMP;
        CurStats.Atk = _baseStats.Atk;
        CurStats.Def = _baseStats.Def;
        CurStats.CC = _baseStats.CC;
        CurStats.CD = _baseStats.CD;
        CurStats.DC = _baseStats.DC;
        CurStats.Level = 1;
        CurStats.Exp = 0;
        CurStats.Gold = 1500;
    }
}

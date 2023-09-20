using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStatsHandler : MonoBehaviour
{
    [SerializeField] private CharacterStatsData _baseStats;

    public CharacterStatsData CurStats { get; private set; }
    public List<CharacterStatsData> StatsModifiers = new List<CharacterStatsData>();

    private void Awake() {
        UpdateCharacterStatData();
    }

    private void UpdateCharacterStatData() {
        CurStats = new CharacterStatsData();

        CurStats.MaxHP = _baseStats.MaxHP;
    }
}

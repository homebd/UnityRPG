using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatsHandler : MonoBehaviour
{
    [SerializeField] private StatsSO _baseStats;

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

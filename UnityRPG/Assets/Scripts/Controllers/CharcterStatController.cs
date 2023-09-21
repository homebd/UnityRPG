using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStatController : MonoBehaviour
{
    public event Action<CharacterStatsHandler> OnChangeStatEvent;
    public event Action<CharacterStatsHandler> OnChangeGoldEvent;
    public event Action<CharacterStatsHandler> OnInitEvent;

    protected CharacterStatsHandler Stats;

    private void Awake() {
        Stats = GetComponent<CharacterStatsHandler>();
    }

    public void CallChangeStatEvent(CharacterStatsHandler stat) {
        OnChangeStatEvent?.Invoke(stat);
    }

    public void CallChangeGoldEvent(CharacterStatsHandler stat) {
        OnChangeGoldEvent?.Invoke(stat);
    }

    // 임시
    private void Update() {
        CallChangeStatEvent(Stats);
    }

    public bool CheckGold(int gold) {
        return Stats.CurStats.Gold >= gold;
    }
    public void ChangeGold(int gold) {
        Stats.CurStats.Gold += gold;
        CallChangeGoldEvent(Stats);
    }
    public void Init() {
        CallInitEvent(Stats);
    }
    public void CallInitEvent(CharacterStatsHandler stat) {
        OnInitEvent?.Invoke(stat);
    }
}

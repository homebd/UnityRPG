using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStatController : MonoBehaviour
{
    public event Action<CharacterStatsHandler> OnChangeStatEvent;

    protected CharacterStatsHandler Stats;

    private void Awake() {
        Stats = GetComponent<CharacterStatsHandler>();
    }

    public void CallChangeStatEvent(CharacterStatsHandler stat) {
        OnChangeStatEvent?.Invoke(stat);
    }

    // 임시
    private void Update() {
        CallChangeStatEvent(Stats);
    }
}

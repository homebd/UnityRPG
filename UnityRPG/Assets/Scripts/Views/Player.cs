using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private RuntimeAnimatorController[] _AnimCon;

    private Animator _anim;

    private void Awake()
    {
        GameManager.Instance.PlayerStat.OnInitEvent += SetAnim;
        _anim = GetComponentInChildren<Animator>();
    }

    private void SetAnim(CharacterStatsHandler stat) {
        _anim.runtimeAnimatorController = _AnimCon[(int)stat.CurStats.Type];
    }
}

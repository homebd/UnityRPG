using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private RuntimeAnimatorController[] _AnimCon;

    private Animator _anim;
    PlayerStatsData _data;

    private void Awake()
    {
        _anim = GetComponentInChildren<Animator>();
    }

    private void Start() {
        _anim.runtimeAnimatorController = _AnimCon[(int)_data.Type];
    }
}

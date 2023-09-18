using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private RuntimeAnimatorController[] _AnimCon;

    private Animator _anim;

    private void Awake()
    {
        _anim = GetComponentInChildren<Animator>();
        Init(0);
    }

    public void Init(int data)
    {
        _anim.runtimeAnimatorController = _AnimCon[data];
    }
}

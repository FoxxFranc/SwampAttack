using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AttackState : State
{
    [SerializeField] private int _dammage;
    [SerializeField] private float _delay;

    private float _lastAtackTime;
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (_lastAtackTime <= 0)
        {
            Attack(Target);
            _lastAtackTime = _delay;
        }
        _lastAtackTime -= Time.deltaTime;
    }

    private void Attack(Player target)
    {
        _animator.Play("Attack");
        target.ApplyDamage(_dammage);
    }
}

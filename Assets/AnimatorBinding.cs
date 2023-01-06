using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AnimatorBinding : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] PlayerAttack _attack;
    [SerializeField] Animator _animator;
    [SerializeField] PlayerMove _move;
    [SerializeField] EntityHealth _Hp;


    private void Start()
    {
        _move.OnStartMove += setMove;
        _move.OnStopMove += stopMove;
        _attack.OnStartAttack += setAttack;
        _attack.OnStopAttack += stopAttack;
        _Hp.OnStartDamage += setDamage;
        _Hp.OnStopDamage += stopDamage;
    }

    private void stopDamage()
    {
        _animator.SetBool("GetHit", false);
    }

    private void setDamage()
    {
        _animator.SetBool("GetHit", true);
    }

    private void stopAttack()
    {
        _animator.SetBool("Attack", false);
    }

    private void setAttack()
    {
        _animator.SetBool("Attack", true);
    }

    private void stopMove()
    {
        _animator.SetBool("Walking", false);
    }

    private void setMove()
    {
        _animator.SetBool("Walking",true);
    }

}

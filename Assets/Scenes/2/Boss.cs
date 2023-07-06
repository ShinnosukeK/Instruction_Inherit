using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : EnemyBase
{
    protected override void Attack() {
        base.Attack();
    }
    void Start() {
        _player = GameObject.Find("Player");
        _bulletSpeed = 10.0f;
        InvokeRepeating("Attack",0.0f,1.0f);
    }
}

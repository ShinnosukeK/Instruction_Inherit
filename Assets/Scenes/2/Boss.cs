using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : EnemyBase
{
    //【Step4】publicにしないと外部クラスから呼べないので、protected→publicに
    //Step5はEnemyBase.csへ
    protected override void Attack() {
        base.Attack();
    }
    void Start() {
        _player = GameObject.Find("Player");
        _bulletSpeed = 10.0f;
        InvokeRepeating("Attack",0.0f,1.0f);
    }
}

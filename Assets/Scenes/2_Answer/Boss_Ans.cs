using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_Ans : EnemyBase_Ans
{
    protected override void Attack() {
        base.Attack();
    }
    void Start() {
        _player = GameObject.Find("Player");
        //�yStep4�z������ł�Player��T���B_player�́yStep2�z��
        //protected�ɕύX�����̂ŁA�����炩����A�N�Z�X���ł���悤�ɂȂ��Ă���B
        _bulletSpeed = 10.0f;
        InvokeRepeating("Attack",0.0f,1.0f);
    }
}

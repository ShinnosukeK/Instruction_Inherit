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
        //【Step4】こちらでもPlayerを探索。_playerは【Step2】で
        //protectedに変更したので、こちらからもアクセスができるようになっている。
        _bulletSpeed = 10.0f;
        InvokeRepeating("Attack",0.0f,1.0f);
    }
}

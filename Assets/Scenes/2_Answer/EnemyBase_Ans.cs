using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase_Ans : MonoBehaviour
{
    protected int _hp;
    protected int _atk;
    protected float _bulletSpeed = 2.0f;
    [SerializeField] GameObject _bulletPrefab;
    protected GameObject _player;//【Step2】private→protectedへ

    [SerializeField] float howFarToInstantiateBullets = 0.5f;
    protected virtual void Attack() {
        var pos = transform.position;
        var targetPos = _player.transform.position;
        //【Step1】_playerはprivate変数なので、派生クラスであるBossクラスからもアクセスは
        //できないです。したがって、Step2にあるように、_playerをprotectedにする必要が
        //あります。しかしこれでもエラーは残ります。


        var dir = (targetPos - pos).normalized;

        var instantiatePos = pos + howFarToInstantiateBullets * dir;
        var rot = _bulletPrefab.transform.rotation;
        var go = Instantiate(_bulletPrefab, instantiatePos, rot);

        var rb = go.GetComponent<Rigidbody>();        
        rb.velocity = _bulletSpeed * dir;
    }
    void Start() {
        _player = GameObject.Find("Player");
        //【Step3】今回はStartメソッド内でPlayerを探索していましたが、派生クラスのBoss側では
        //基底クラスのStartメソッドは実行していないため、Playerの探索ができていないのです。
        //そこで、Boss_Ans.cs【Step4】のようにすることになります。
        InvokeRepeating("Attack",0.0f, 0.5f);    
    }
}

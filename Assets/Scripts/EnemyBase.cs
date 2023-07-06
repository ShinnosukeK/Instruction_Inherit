using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    protected int _hp;
    protected int _atk;
    protected float _bulletSpeed = 2.0f;
    [SerializeField] GameObject _bulletPrefab;
    protected GameObject _player;

    [SerializeField] float howFarToInstantiateBullets = 0.5f;

    //【Step5】publicにしないと外部クラスから呼べないので、protected→publicに
    public virtual void Attack() {
        //生成準備
        var pos = transform.position;
        var targetPos = _player.transform.position;
        var dir = (targetPos - pos).normalized;//EnemyからPlayer方向

        //生成
        var instantiatePos = pos + howFarToInstantiateBullets * dir;//Enemy中心から少しPlayer寄りに生成位置
        var rot = _bulletPrefab.transform.rotation;
        var go = Instantiate(_bulletPrefab, instantiatePos, rot);

        //移動
        var rb = go.GetComponent<Rigidbody>();
        rb.velocity = _bulletSpeed * dir;
    }
    void Start() {
        _player = GameObject.Find("Player");
        InvokeRepeating("Attack", 0.0f, 0.5f);
    }
}

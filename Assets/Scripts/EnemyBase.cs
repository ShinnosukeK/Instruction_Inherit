using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    protected int _hp;
    protected int _atk;
    protected float _bulletSpeed = 2.0f;
    [SerializeField] GameObject _bulletPrefab;
    GameObject _player;

    [SerializeField] float howFarToInstantiateBullets = 0.5f;
    protected virtual void Attack() {
        //��������
        var pos = transform.position;
        var targetPos = _player.transform.position;
        var dir = (targetPos - pos).normalized;//Enemy����Player����

        //����
        var instantiatePos = pos + howFarToInstantiateBullets * dir;//Enemy���S���班��Player���ɐ����ʒu
        var rot = _bulletPrefab.transform.rotation;
        var go = Instantiate(_bulletPrefab, instantiatePos, rot);

        //�ړ�
        var rb = go.GetComponent<Rigidbody>();        
        rb.velocity = _bulletSpeed * dir;
    }
    void Start() {
        _player = GameObject.Find("Player");
        InvokeRepeating("Attack",0.0f, 0.5f);    
    }
}

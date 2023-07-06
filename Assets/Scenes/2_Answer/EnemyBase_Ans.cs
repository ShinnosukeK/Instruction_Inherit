using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase_Ans : MonoBehaviour
{
    protected int _hp;
    protected int _atk;
    protected float _bulletSpeed = 2.0f;
    [SerializeField] GameObject _bulletPrefab;
    protected GameObject _player;//�yStep2�zprivate��protected��

    [SerializeField] float howFarToInstantiateBullets = 0.5f;
    protected virtual void Attack() {
        var pos = transform.position;
        var targetPos = _player.transform.position;
        //�yStep1�z_player��private�ϐ��Ȃ̂ŁA�h���N���X�ł���Boss�N���X������A�N�Z�X��
        //�ł��Ȃ��ł��B���������āAStep2�ɂ���悤�ɁA_player��protected�ɂ���K�v��
        //����܂��B����������ł��G���[�͎c��܂��B


        var dir = (targetPos - pos).normalized;

        var instantiatePos = pos + howFarToInstantiateBullets * dir;
        var rot = _bulletPrefab.transform.rotation;
        var go = Instantiate(_bulletPrefab, instantiatePos, rot);

        var rb = go.GetComponent<Rigidbody>();        
        rb.velocity = _bulletSpeed * dir;
    }
    void Start() {
        _player = GameObject.Find("Player");
        //�yStep3�z�����Start���\�b�h����Player��T�����Ă��܂������A�h���N���X��Boss���ł�
        //���N���X��Start���\�b�h�͎��s���Ă��Ȃ����߁APlayer�̒T�����ł��Ă��Ȃ��̂ł��B
        //�����ŁABoss_Ans.cs�yStep4�z�̂悤�ɂ��邱�ƂɂȂ�܂��B
        InvokeRepeating("Attack",0.0f, 0.5f);    
    }
}

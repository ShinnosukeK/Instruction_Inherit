using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�yStep5�z�����ł�IDamageable���p�����悤
public class Obstacle : MonoBehaviour, IDamageable
{
    //�yStep6�z����������ƁCIDamageable����_hp�Ƃ����ʂŒ�`���Ă�����
    // �p����ł���Player�Ƃ�Obstacle���ł��g���邵�C�܂Ƃ߂Ă���������...
    // �ƍl�������Ȃ��D���͂ł��܂���D�����ɁC
    // IDamageable�ɑ΂���protected int _hp;�Ȃǂƃt�B�[���h�ɒ�`���Ă݂悤�D
    // �o���Ȃ��Ǝv���D�������Cconst int _hp = 100;�Ƃ�����΃G���[�͏o�Ȃ��D
    // ���̂悤�ɁC�萔�iconst�j����interface�ɂ͒�`���邱�Ƃ��ł��Ȃ��D


    //�yStep7�zDamage���\�b�h�̎������Catk��2�{������_hp��������悤�ɂ��悤�D
    // �������C_hp�͐V�����t�B�[���h�ɒ�`���邱�ƁD
    int _hp;
    public void Damage(int atk)
    {
        _hp -= 2 * atk;
        Debug.Log("��Q����HP:" + _hp);
        CheckDead();
    }

    //�yStep8�z���ł�Start����_hp��10�ŏ��������Ă��������D�܂��C
    // Damage���\�b�h���̍Ō�ŁC
    // �@���g��_hp���o�͂����C
    // �ACheckDead���\�b�h���`���C_hp�����ɂȂ��Ă�����
    // �������g��Destroy����悤�ɂ��Ă݂Ă��������D
    void Start()
    {
        _hp = 10;
    }
    void CheckDead()
    {
        if (_hp < 0) Destroy(gameObject);
    }
}
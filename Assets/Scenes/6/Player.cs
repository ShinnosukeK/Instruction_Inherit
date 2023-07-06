using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�yStep2�zPlayer�N���X�́Cinterface IDamageable��ǉ��Ōp������D
//�i���Ӂj�ʏ�C#�ł͑��d�p���i�������p�����邱�Ɓj�͋֎~�D�������Cinterface�̂�
// �������邱�Ƃ�������Ă���D
public class Player : MonoBehaviour, IDamageable
{
    //�yStep3�zIDamageable�̂Ƃ���ɃG���[���o��Ǝv���D�����IDamageable
    // �ɂ����āCDamage���\�b�h���`���Ă��邽�߁C������ŕK�������ڍׂ�
    // �����˂΂Ȃ�Ȃ�����ł���D������Damage���\�b�h���������C
    // �P���Ƀt�B�[���h�i�ɐV���ɒ�`�����jint _hp����atk�����������悤�ɂ��悤�D
    int _hp;
    public void Damage(int atk)
    {
        _hp -= atk;
        Debug.Log("Player��HP:" + _hp);
        CheckDead();
    }


    //�yStep4�z���ł�Start����_hp��100�ŏ��������Ă��������D�܂��C
    // Damage���\�b�h���̍Ō�ŁC
    // �@���g��_hp���o�͂����C
    // �ACheckDead���\�b�h���`���C_hp�����ɂȂ��Ă�����
    // �������g��Destroy����悤�ɂ��Ă݂Ă��������D
    void Start()
    {
        _hp = 100;
    }
    void CheckDead()
    {
        if (_hp < 0) Destroy(gameObject);
    }
}
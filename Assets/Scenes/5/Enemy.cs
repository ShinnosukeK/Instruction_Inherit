using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�yStep2�zEnemy�N���X���CCreature���p�����悤�D
public class Enemy : Creature
{
    //�yStep3�zDamage�֐���override���C�����ł͈�����atk��80%~120%���U���͂̕��Ƃ��C
    // ���̒l����_def�������Ď��g��_hp��������悤�ɂ��悤�D
    // ���Ƃ��΁Catk = 100����������̂ł���΁C80~120�̕��Ń����_���Ȓl���v�Z���悤�D
    // ���������g��_def = 30�ŁC�����_���U���͂�90�Ȃ�΁C60�̃_���[�W��H�炤�悤�ɂ���̂ł���D
    // Step4��Thunder.cs�ցD
    int _def;
    public override void Damage(int atk)
    {
        var atkMax = atk * 120 / 100;
        var atkMin = atk * 80 / 100;
        var randomAtk = Random.Range(atkMin,atkMax);
        _hp -= (randomAtk > _def ? randomAtk - _def : 0);

        Debug.Log("Enemy��HP:" + _hp);
    }


    //�y�⑫�z�����ƓG��HP�Ƃ��������Ă邩�����悤�ɁCStart����_hp��10000�ŏ��������Ă����C
    // Damage���\�b�h����Debug.Log��HP�o�͂����Ă�����
    void Start()
    {
        _hp = 10000;
    }
}

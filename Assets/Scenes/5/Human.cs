using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : Creature
{
    //�yStep1�z_hp��Creature�ł���΁Cplayer�͂������C�؂̂悤�ȕ��̂��������肻�����D
    // �Ȃ̂ŁC_hp��Creature���Ɉڂ��Cprotected�ɂ��悤�DStep2��Enemy.cs�ցD
    int _atk;
    int _def;

    public override void Damage(int atk)
    {
        _hp -= (atk > _def ? atk - _def : 0);
        Debug.Log("�l�Ԃ�HP:" + _hp);
    }

    //�y�⑫�z�����Ɛl�Ԃ�HP�Ƃ��������Ă邩�����悤�ɁCStart����_hp��7000�ŏ��������Ă����C
    // Damage���\�b�h����Debug.Log��HP�o�͂����Ă�����
    void Start()
    {
        _hp = 7000;
    }
}

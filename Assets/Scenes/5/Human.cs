using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : Creature
{
    //�yStep1�z_hp��Creature�ł���΁Cplayer�͂������C�؂̂悤�ȕ��̂��������肻�����D
    // �Ȃ̂ŁC_hp��Creature���Ɉڂ��Cprotected�ɂ��悤�DStep2��Enemy.cs�ցD
    int _hp;
    int _atk;
    int _def;

    public override void Damage(int atk)
    {
        _hp -= (atk > _def ? atk - _def : 0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : Creature
{
    //【Step1】_hpはCreatureであれば，playerはもちろん，木のような物体さえもありそうだ．
    // なので，_hpはCreature側に移し，protectedにしよう．Step2はEnemy.csへ．
    int _hp;
    int _atk;
    int _def;

    public override void Damage(int atk)
    {
        _hp -= (atk > _def ? atk - _def : 0);
    }
}

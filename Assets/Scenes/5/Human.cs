using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : Creature
{
    //【Step1】_hpはCreatureであれば，playerはもちろん，木のような物体さえもありそうだ．
    // なので，_hpはCreature側に移し，protectedにしよう．Step2はEnemy.csへ．
    int _atk;
    int _def;

    public override void Damage(int atk)
    {
        _hp -= (atk > _def ? atk - _def : 0);
        Debug.Log("人間のHP:" + _hp);
    }

    //【補足】ちゃんと人間のHPとかも減ってるか見れるように，Start内で_hpを7000で初期化しておき，
    // Damageメソッド内にDebug.LogでHP出力させておいた
    void Start()
    {
        _hp = 7000;
    }
}

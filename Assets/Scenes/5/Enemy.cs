using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//【Step2】Enemyクラスも，Creatureを継承しよう．
public class Enemy : Creature
{
    //【Step3】Damage関数をoverrideし，ここでは引数のatkの80%~120%を攻撃力の幅とし，
    // その値から_defを引いて自身の_hpから引くようにしよう．
    // たとえば，atk = 100をもらったのであれば，80~120の幅でランダムな値を計算しよう．
    // もしも自身の_def = 30で，ランダム攻撃力が90ならば，60のダメージを食らうようにするのである．
    // Step4はThunder.csへ．
    int _def;
    public override void Damage(int atk)
    {
        var atkMax = atk * 120 / 100;
        var atkMin = atk * 80 / 100;
        var randomAtk = Random.Range(atkMin,atkMax);
        _hp -= (randomAtk > _def ? randomAtk - _def : 0);

        Debug.Log("EnemyのHP:" + _hp);
    }


    //【補足】ちゃんと敵のHPとかも減ってるか見れるように，Start内で_hpを10000で初期化しておき，
    // Damageメソッド内にDebug.LogでHP出力させておいた
    void Start()
    {
        _hp = 10000;
    }
}

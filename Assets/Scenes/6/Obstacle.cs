using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//【Step5】ここでもIDamageableを継承しよう
public class Obstacle : MonoBehaviour, IDamageable
{
    //【Step6】もしかすると，IDamageable側に_hpとか共通で定義しておけば
    // 継承先であるPlayerとかObstacle側でも使えるし，まとめておこうかな...
    // と考えたあなた．実はできません．試しに，
    // IDamageableに対してprotected int _hp;などとフィールドに定義してみよう．
    // 出来ないと思う．しかし，const int _hp = 100;とかすればエラーは出ない．
    // このように，定数（const）しかinterfaceには定義することができない．


    //【Step7】Damageメソッドの実装を，atkの2倍分だけ_hpから引くようにしよう．
    // もちろん，_hpは新しくフィールドに定義すること．
    int _hp;
    public void Damage(int atk)
    {
        _hp -= 2 * atk;
        Debug.Log("障害物のHP:" + _hp);
        CheckDead();
    }

    //【Step8】ついでにStart内で_hpを10で初期化してください．また，
    // Damageメソッド内の最後で，
    // ①自身の_hpを出力させ，
    // ②CheckDeadメソッドを定義し，_hpが負になっていたら
    // 自分自身をDestroyするようにしてみてください．
    void Start()
    {
        _hp = 10;
    }
    void CheckDead()
    {
        if (_hp < 0) Destroy(gameObject);
    }
}
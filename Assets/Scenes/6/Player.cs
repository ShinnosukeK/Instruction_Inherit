using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//【Step2】Playerクラスは，interface IDamageableを追加で継承する．
//（注意）通常C#では多重継承（いくつも継承すること）は禁止．ただし，interfaceのみ
// 複数することが許されている．
public class Player : MonoBehaviour, IDamageable
{
    //【Step3】IDamageableのところにエラーが出ると思う．これはIDamageable
    // において，Damageメソッドを定義しているため，こちらで必ず実装詳細を
    // 書かねばならないからである．ここでDamageメソッドを実装し，
    // 単純にフィールド（に新たに定義した）int _hpからatk分だけ引くようにしよう．
    int _hp;
    public void Damage(int atk)
    {
        _hp -= atk;
        Debug.Log("PlayerのHP:" + _hp);
        CheckDead();
    }


    //【Step4】ついでにStart内で_hpを100で初期化してください．また，
    // Damageメソッド内の最後で，
    // ①自身の_hpを出力させ，
    // ②CheckDeadメソッドを定義し，_hpが負になっていたら
    // 自分自身をDestroyするようにしてみてください．
    void Start()
    {
        _hp = 100;
    }
    void CheckDead()
    {
        if (_hp < 0) Destroy(gameObject);
    }
}
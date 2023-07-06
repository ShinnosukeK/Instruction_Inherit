using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//【Step1】クラスを抽象化（abstract）してください．
public class Creature : MonoBehaviour
{
    //【Step2】Damageは生き物ならだれでも受けそうなので，派生クラスで必ずoverrideして
    //詳細な実装を書いてもらうためにも，抽象化（abstract）してください．
    public void Damage(int atk)
    {

    }
    //【Step3】メソッドをabstractしてしまうと，body（本体）を書くことは許されないので，
    // 上記Damageメソッドの{}を消して，...Damage();と終えましょう．
}

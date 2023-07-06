using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//【Step4】基底クラスのDamageメソッドがabstractになってしまったので，
// 派生クラスであるHumanクラスでは，必ずDamageメソッドをoverrideする
// 必要が出てくるため，下のようにエラーが出ます．（カーソルを合わせ，エラーを一度は見ること）
public class Human : Creature
{
    //【Step5】フィールドにint型の_hp, _atk（攻撃力）, _def（防御力）を定義してください

    //【Step6】ここでDamage関数をoverrideし，
    // 内部実装は，受け取ったatkから_def（防御力）を引いたものを，_hpから引くようにしよう．
    // ただし，atkよりも_defが上回る場合は，ダメージ量を0にしよう．
}

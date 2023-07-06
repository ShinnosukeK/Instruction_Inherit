using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable
{
    //【Step1】int atkを受け取るDamageメソッド（public）を定義
    public void Damage(int atk);
}

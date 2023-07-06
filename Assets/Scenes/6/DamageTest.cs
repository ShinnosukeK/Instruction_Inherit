using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTest : MonoBehaviour
{
    //【Step9】PlayerスクリプトとObstacleスクリプトをSerializeFieldで宣言し，
    // インスペクタから指定しておこう．
    [SerializeField] Player playerScript;
    [SerializeField] Obstacle obstacleScript;
    void Update()
    {
        //【Step10】スペースキーが押されたら，IDamageable型の変数objに
        // Playerスクリプトを入れてみて，objのDamageメソッドに2を与えて，
        // ダメージ処理を依頼しよう．
        // さらに，同じobjに対してObstacleスクリプトを入れてみて，
        // objのDamageメソッドに3を与えてダメージ処理を依頼しよう．
        if (Input.GetKeyDown(KeyCode.Space))
        {
            IDamageable obj = playerScript;
            obj.Damage(2);

            obj = obstacleScript;
            obj.Damage(3);
        }
    }
}
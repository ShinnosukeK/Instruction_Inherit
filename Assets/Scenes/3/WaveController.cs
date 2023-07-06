using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveController : MonoBehaviour
{
    //ヒエラルキーに存在する敵オブジェクト（ボス含む）を
    //リスト化し、BossならBoss専用のAttack、ふつうのEnemyBaseなら
    //EnemyBase専用のAttackを実行させるWaveを作れないでしょうか？

    //【Step1】EnemyBase型の配列enemyScriptsを定義
    EnemyBase[] enemyScripts;


    void Start() {
        //【Step2】enemyScriptsに対して、FindObjectsOfTypeメソッドを用い、EnemyBaseスクリプトを
        //持ったオブジェクトの配列を代入する
        enemyScripts = FindObjectsOfType<EnemyBase>();
    }

    void Update() {
        //【Step3】enemyScriptsがもつAttack関数を実行させる。ただし、
        //全体を「スペースキーが押されたら」のif文で一旦くくり、
        //スペースが押されたら全エネミーが弾を打ってくるようなDebug仕様にすること
        //Step4はBoss.csへ
        if(Input.GetKeyDown(KeyCode.Space)) {
            foreach(var e in enemyScripts) {
                e.Attack();
                //【重要】ここで凄いのは、本来EnemyBaseがついている敵と、Bossがついている敵では
                //スクリプト名が違うので、分けてGetComponentのようなことをしないといけない気がするのだが。
                //Startメソッドに書いたように、EnemyBase型ということでBoss型も処理しちゃって、
                //あたかもすべてEnemyBaseのようなイメージでAttackを実行すると、内部的には
                //Boss型のAttackがきちんと呼び出されるようになっているのである。
                //これを多態性（ポリモーフィズム）という。
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thunder : MonoBehaviour
{ 
    void Update()
    {
        //【Step4】デバッグ的に，スペースキーを押したら雷を再生（配置しているPrefabを有効にする）
        // 再生の本体メソッドは，StartThunderコルーチンとして書くこと．
    }
    

    //【Step5（終）】hierarchy上にいるCreature系（派生クラスであるEnemyやHuman含む）を全検索し，
    // それらに1000のatkを与えてダメージ計算をするように依頼する．
    // その後2秒たったら再生しているPrefabを向こうにして，雷のアニメを消すこと．
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thunder : MonoBehaviour
{ 
    void Update()
    {
        //【Step4】デバッグ的に，スペースキーを押したら雷を再生（配置しているPrefabを有効にする）
        // 再生の本体メソッドは，StartThunderコルーチンとして書くこと．
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(StartThunder());
        }
    }
    

    //【Step5（終）】hierarchy上にいるCreature系（派生クラスであるEnemyやHuman含む）を全検索し，
    // それらに1000のatkを与えてダメージ計算をするように依頼する．
    // その後2秒たったら再生しているPrefabを無効にして，雷のアニメを消すこと．
    IEnumerator StartThunder()
    {
        var clouds = transform;
        foreach(Transform t in clouds)
        {
            if(t.tag == "Thunder") t.gameObject.SetActive(true);
        }

        Creature[] creatures = FindObjectsOfType<Creature>();
        foreach (var c in creatures)
        {
            c.Damage(1000);
        }

        yield return new WaitForSeconds(2);

        foreach(Transform t in clouds)
        {
            if (t.tag == "Thunder") t.gameObject.SetActive(false);
        }
    }
}

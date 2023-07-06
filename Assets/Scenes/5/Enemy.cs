using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//【Step2】Enemyクラスも，Creatureを継承しよう．
public class Enemy : MonoBehaviour
{
    //【Step3】Damage関数をoverrideし，ここでは引数のatkの80%~120%を攻撃力の幅とし，
    // その値から_defを引いて自身の_hpから引くようにしよう．
    // たとえば，atk = 100をもらったのであれば，80~120の幅でランダムな値を計算しよう．
    // もしも自身の_def = 30で，ランダム攻撃力が90ならば，60のダメージを食らうようにするのである．
    // Step4はThunder.csへ．
}

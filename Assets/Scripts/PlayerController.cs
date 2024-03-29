using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed;
    void Update()
    {
        //入力
        float h = 0.0f, v = 0.0f;
        if(Input.GetKey(KeyCode.W)) {
            v += 1.0f;
        }
        if(Input.GetKey(KeyCode.S)) {
            v += -1.0f;
        }
        if(Input.GetKey(KeyCode.D)) {
            h += 1.0f;
        }
        if(Input.GetKey(KeyCode.A)) {
            h += -1.0f;
        }

        //移動方向決定
        var dir = new Vector3(h,0,v);
        dir.Normalize();

        //移動
        transform.Translate(dir * speed * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed;
    void Update()
    {
        //����
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

        //�ړ���������
        var dir = new Vector3(h,0,v);
        dir.Normalize();

        //�ړ�
        transform.Translate(dir * speed * Time.deltaTime);
    }
}

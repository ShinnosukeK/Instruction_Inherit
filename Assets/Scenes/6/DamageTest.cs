using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTest : MonoBehaviour
{
    //�yStep9�zPlayer�X�N���v�g��Obstacle�X�N���v�g��SerializeField�Ő錾���C
    // �C���X�y�N�^����w�肵�Ă������D
    [SerializeField] Player playerScript;
    [SerializeField] Obstacle obstacleScript;
    void Update()
    {
        //�yStep10�z�X�y�[�X�L�[�������ꂽ��CIDamageable�^�̕ϐ�obj��
        // Player�X�N���v�g�����Ă݂āCobj��Damage���\�b�h��2��^���āC
        // �_���[�W�������˗����悤�D
        // ����ɁC����obj�ɑ΂���Obstacle�X�N���v�g�����Ă݂āC
        // obj��Damage���\�b�h��3��^���ă_���[�W�������˗����悤�D
        if (Input.GetKeyDown(KeyCode.Space))
        {
            IDamageable obj = playerScript;
            obj.Damage(2);

            obj = obstacleScript;
            obj.Damage(3);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveController : MonoBehaviour
{
    //�q�G�����L�[�ɑ��݂���G�I�u�W�F�N�g�i�{�X�܂ށj��
    //���X�g�����ABoss�Ȃ�Boss��p��Attack�A�ӂ���EnemyBase�Ȃ�
    //EnemyBase��p��Attack�����s������Wave�����Ȃ��ł��傤���H

    //�yStep1�zEnemyBase�^�̔z��enemyScripts���`
    EnemyBase[] enemyScripts;


    void Start() {
        //�yStep2�zenemyScripts�ɑ΂��āAFindObjectsOfType���\�b�h��p���AEnemyBase�X�N���v�g��
        //�������I�u�W�F�N�g�̔z���������
        enemyScripts = FindObjectsOfType<EnemyBase>();
    }

    void Update() {
        //�yStep3�zenemyScripts������Attack�֐������s������B�������A
        //�S�̂��u�X�y�[�X�L�[�������ꂽ��v��if���ň�U������A
        //�X�y�[�X�������ꂽ��S�G�l�~�[���e��ł��Ă���悤��Debug�d�l�ɂ��邱��
        //Step4��Boss.cs��
        if(Input.GetKeyDown(KeyCode.Space)) {
            foreach(var e in enemyScripts) {
                e.Attack();
                //�y�d�v�z�����Ő����̂́A�{��EnemyBase�����Ă���G�ƁABoss�����Ă���G�ł�
                //�X�N���v�g�����Ⴄ�̂ŁA������GetComponent�̂悤�Ȃ��Ƃ����Ȃ��Ƃ����Ȃ��C������̂����B
                //Start���\�b�h�ɏ������悤�ɁAEnemyBase�^�Ƃ������Ƃ�Boss�^��������������āA
                //�����������ׂ�EnemyBase�̂悤�ȃC���[�W��Attack�����s����ƁA�����I�ɂ�
                //Boss�^��Attack��������ƌĂяo�����悤�ɂȂ��Ă���̂ł���B
                //����𑽑Ԑ��i�|�����[�t�B�Y���j�Ƃ����B
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//�yStep1�z�N���X�𒊏ۉ��iabstract�j���Ă��������D
public class Creature : MonoBehaviour
{
    //�yStep2�zDamage�͐������Ȃ炾��ł��󂯂����Ȃ̂ŁC�h���N���X�ŕK��override����
    //�ڍׂȎ����������Ă��炤���߂ɂ��C���ۉ��iabstract�j���Ă��������D
    public void Damage(int atk)
    {

    }
    //�yStep3�z���\�b�h��abstract���Ă��܂��ƁCbody�i�{�́j���������Ƃ͋�����Ȃ��̂ŁC
    // ��LDamage���\�b�h��{}�������āC...Damage();�ƏI���܂��傤�D
}

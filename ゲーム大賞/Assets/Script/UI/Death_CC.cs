using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;  // �ǉ����܂��傤

public class Death_CC : MonoBehaviour
{
    public GameObject score_object = null; // Text�I�u�W�F�N�g

    public int sateg_deth;

    int death_Count = 0;
    // ������
    void Start()
    {
    }

    // �X�V
    void Update()
    {
        death_Count = Player.instance.GetDeathCount();

        if (sateg_deth - death_Count <= 0)
        {
            //GemaOver

        }

        // �I�u�W�F�N�g����Text�R���|�[�l���g���擾
        Text score_text = score_object.GetComponent<Text>();
        // �e�L�X�g�̕\�������ւ���
        score_text.text = " �~�@" + (sateg_deth - death_Count);
    }
}
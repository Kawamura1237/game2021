using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;  // �ǉ����܂��傤


public class Score : MonoBehaviour
{
    public GameObject score_object = null; // Text�I�u�W�F�N�g

    public int x;
    // ������
    void Start()
    {
        x = 10;
    }

    // �X�V
    void Update()
    {
        // �I�u�W�F�N�g����Text�R���|�[�l���g���擾
        Text score_text = score_object.GetComponent<Text>();
        // �e�L�X�g�̕\�������ւ���
        score_text.text = "���񂾉񐔁@"+ x; 
    }
}
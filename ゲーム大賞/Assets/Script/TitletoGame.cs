using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TitletoGame : MonoBehaviour
{

    // �{�^���������ꂽ�ꍇ�A����Ăяo�����֐�
    public void OnClick()
    {
        SceneManager.LoadScene("��Scene");
        Debug.Log("�����ꂽ!");  // ���O���o��
    }
}

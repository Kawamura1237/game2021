using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TitletoGame : MonoBehaviour
{

    // �{�^���������ꂽ�ꍇ�A����Ăяo�����֐�
    public void OnClick()
    {
        //SceneManager.LoadScene("stage1");
        FadeManager.FadeOut(1);
        Debug.Log("�����ꂽ!");  // ���O���o��
    }
}

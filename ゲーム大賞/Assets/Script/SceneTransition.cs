using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneTransition: MonoBehaviour
{

    //���̊֐����Ăяo����Buildsetting�̃V�[���̔ԍ��ňړ�����V�[����I��
    public static void Nextscene(int n)
    {
        FadeManager.FadeOut(n);
    }
}

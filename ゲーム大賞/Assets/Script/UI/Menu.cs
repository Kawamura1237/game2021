using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    private GameObject child;                           //Canvas�̎q���iUIManager�������j
    private GameObject[] ButtonUI = new GameObject[4];    //���j���[�̃{�^�����擾�@�{�^���̐���[]�̒��ɂ����
    private bool PauseCheck;                            //�ꎞ��~���Ă��邩�̂̔���
    private int num;�@                                  //�{�^������p�̐�
    public AudioSource audioSource;                     //SE�폜�p
    [SerializeField] int ThisScene;
    // Start is called before the first frame update
    void Start()
    {
        num = 0;
        PauseCheck = false;
        child = transform.Find("UIManager").gameObject;             //UIManager�擾
        for (int i = 0; i < ButtonUI.Length; i++)
        {
            ButtonUI[i] = child.transform.GetChild(i + 2).gameObject; //�{�^���擾
        }
        child.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();//�ꎞ��~
        }



        if (PauseCheck)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                ButtonUI[num].transform.localScale /= 1.1f;
                num--;
                if (num < 0)
                {
                    num = ButtonUI.Length - 1;
                }
                ButtonUI[num].transform.localScale *= 1.1f;
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                ButtonUI[num].transform.localScale /= 1.1f;
                num++;
                if (num > ButtonUI.Length - 1)
                {
                    num = 0;
                }
                ButtonUI[num].transform.localScale *= 1.1f;
            }

            if (Input.GetKeyDown(KeyCode.Return))
            {
                switch (num)
                {
                    case 0:
                        UnPause();//�Đ�
                        break;
                    case 1:
                        UnPause();
                        SceneTransition.Nextscene(0);
                        break;
                    case 2:
                        UnPause();
                        SceneTransition.Nextscene(ThisScene);   //�C���X�y�N�^�[�ŃV�[����ݒ�@���X�^�[�g�p
                        break;
                    case 3:
                        #if UNITY_EDITOR
                            UnityEditor.EditorApplication.isPlaying = false;
                        #else
                            Application.Quit();
                        #endif
                        break;
                    default:
                        break;
                }
            }
        }
    }

    private void Pause()
    {
        Time.timeScale = 0;
        audioSource.enabled = false;
        child.SetActive(true);
        PauseCheck = true;
        ButtonUI[0].transform.localScale *= 1.1f;
    }
    private void UnPause()
    {
        Time.timeScale = 1;
        child.SetActive(false);
        audioSource.enabled = true;
        PauseCheck = false;
    }
}

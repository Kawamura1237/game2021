using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button1 : MonoBehaviour
{
    public GameObject box;//��
    public bool open;
    public GameObject child;
    public AudioClip BGM_Gim;

    // Start is called before the first frame update
    void Start()
    {
        open = false;
        Debug.Log("Child:" + child.name);//�q�̃��O
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionStay2D(Collision2D col)
    {
        //���̏ꍇ
        if (col.gameObject.name == "box")
        {
            if (box.gameObject.activeInHierarchy)
            {
                Debug.Log("��������Ă�");
                open = true;
                //�֐��Ăяo���A�G���[���⋓�������������ꍇ�ꎞ����
                child.GetComponent<Door1>().DoirOpen1();
                SE.instance.PlaySE(BGM_Gim);
            }
        }
    }

    void OnCollisionExit2D(Collision2D col)
    {
        //���̏ꍇ
        if (box.gameObject.activeInHierarchy)
        {
            Debug.Log("�������ꂽ");
            open = false;
            //�֐��Ăяo���A�G���[���⋓�������������ꍇ�ꎞ����
            child.GetComponent<Door1>().DoirClose1();
        }
    }
}

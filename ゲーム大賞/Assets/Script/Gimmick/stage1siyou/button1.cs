using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button1 : MonoBehaviour
{
    GameObject havescript;
    //public GameObject who;//�l
    public GameObject box;//��
    public bool open;

    // Start is called before the first frame update
    void Start()
    {
        havescript = GameObject.Find("door");
        open = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionStay2D(Collision2D col)
    {
        //�l�̏ꍇ
        //if (col.gameObject.name == "Human")
        //{
        //    if (who.gameObject.activeInHierarchy)
        //    {
        //        Debug.Log("�l������Ă�");
        //        open = true;
        //        //�֐��Ăяo���A�G���[���⋓�������������ꍇ�ꎞ����
        //        havescript.GetComponent<Mover>().DoirOpen();
        //    }
        //}

        //���̏ꍇ
        if (col.gameObject.name == "box")
        {
            if (box.gameObject.activeInHierarchy)
            {
                Debug.Log("��������Ă�");
                open = true;
                //�֐��Ăяo���A�G���[���⋓�������������ꍇ�ꎞ����
                havescript.GetComponent<Door1>().DoirOpen();
            }
        }
    }

    void OnCollisionExit2D(Collision2D col)
    {
        //�l�̏ꍇ
        //if (who.gameObject.activeInHierarchy)
        //{
        //    Debug.Log("�l�����ꂽ");
        //    open = false;
        //    //�֐��Ăяo���A�G���[���⋓�������������ꍇ�ꎞ����
        //    havescript.GetComponent<Mover>().DoirClose();
        //}

        //���̏ꍇ
        if (box.gameObject.activeInHierarchy)
        {
            Debug.Log("�������ꂽ");
            open = false;
            //�֐��Ăяo���A�G���[���⋓�������������ꍇ�ꎞ����
            havescript.GetComponent<Door1>().DoirClose();
        }
    }
}

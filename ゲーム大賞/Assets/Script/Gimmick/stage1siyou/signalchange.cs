using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class signalchange : MonoBehaviour
{
    GameObject havescript1;//�ʂ�sc����֐����Ă�
    GameObject havescript2;
    public GameObject child;
    public GameObject child2;

    public GameObject who;
    bool awake;

    public float seconds;//�������N�[���^�C��

    // Start is called before the first frame update
    void Start()
    {
        havescript1 = GameObject.Find("red");
        havescript2 = GameObject.Find("green");
        awake = false;
        havescript1.GetComponent<Red>().ColorChange();//�ԃI��
        havescript2.GetComponent<Green>().NoColorChange2P();//�΃I�t

        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.name == "Player")
        {
            if (who.gameObject.activeInHierarchy)
            {
                Debug.Log("�l���̈�ɓ����Ă�");
                if (awake == true)
                {
                    seconds += Time.deltaTime;
                    if (seconds >= 0.25)
                    {
                        if (Input.GetKey(KeyCode.K))
                        {
                            //�֐��Ăяo���A�G���[���⋓�������������ꍇ�ꎞ����
                            havescript2.GetComponent<Green>().ColorChange2P();//�΃I��
                            havescript1.GetComponent<Red>().NoColorChange();//�ԃI�t
                            int count = 0;//on�u���b�N�p
                            int count2 = 0;//off�u���b�N�p
                            foreach (Transform child in transform)
                            {
                                Debug.Log("Child[" + count + "]:" + child.name);
                                child.GetComponent<skellton>().WallAlfaCri();//�R�����W�������X��t����
                                count++;
                                
                            }
                            foreach (Transform child2 in transform)
                            {
                                Debug.Log("Child[" + count2 + "]:" + child2.name);
                                child2.GetComponent<skellton2>().WallBetaDes();//�R�����W�������X������
                                count2++;
                            }
                            awake = false;
                            seconds = 0;
                        }
                    }
                }
                else if (awake == false)
                {
                    seconds += Time.deltaTime;
                    if (seconds >= 0.25)
                    {
                        if (Input.GetKey(KeyCode.K))
                        {
                            //�֐��Ăяo���A�G���[���⋓�������������ꍇ�ꎞ����
                            havescript1.GetComponent<Red>().ColorChange();//�ԃI��
                            havescript2.GetComponent<Green>().NoColorChange2P();//�΃I�t
                            int count = 0;
                            int count2 = 0;
                            foreach (Transform child in transform)
                            {
                                Debug.Log("Child[" + count + "]:" + child.name);
                                child.GetComponent<skellton>().WallAlfaDes();//�R�����W�������X������
                                count++;
                                
                            }
                            foreach (Transform child2 in transform)
                            {
                                Debug.Log("Child[" + count2 + "]:" + child2.name);
                                child2.GetComponent<skellton2>().WallBetaCri();//�R�����W�������X��t����
                                count2++;
                                
                            }
                            awake = true;
                            seconds = 0;
                        }
                    }
                }
            }
        }
    }

    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.name == "Player")
        {
            if (who.gameObject.activeInHierarchy)
            {
                Debug.Log("�l�����ꂽ");
                //�֐��Ăяo���A�G���[���⋓�������������ꍇ�ꎞ����
                //havescript1.GetComponent<Red>().ColorChange();
                //havescript2.GetComponent<Green>().NoColorChange2P();
                seconds = 0;
            }
        }
    }
}

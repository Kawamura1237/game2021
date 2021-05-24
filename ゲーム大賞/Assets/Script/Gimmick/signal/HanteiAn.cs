using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HanteiAn : MonoBehaviour
{
    GameObject havescript1;//�ʂ�sc����֐����Ă�
    GameObject havescript2;
    public GameObject havescript3;

    public GameObject who;
    bool awake;

    public float ANseconds;//�������N�[���^�C��

    // Start is called before the first frame update
    void Start()
    {
        havescript1 = GameObject.Find("redAN");
        havescript2 = GameObject.Find("greenAN");
        havescript3 = GameObject.Find("wing");
        awake = false;
        havescript1.GetComponent<RedAn>().AnotherColorChange();
        havescript2.GetComponent<GreenAn>().AnotherNoColorChange2P();
        havescript3.GetComponent<Roller>().ActionPosition();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionStay(Collision col)
    {
        if (col.gameObject.name == "Target")
        {
            if (who.gameObject.activeInHierarchy)
            {

                Debug.Log("�l���G��Ă�");
                if (awake == true)
                {
                    ANseconds += Time.deltaTime;
                    if (ANseconds >= 0.75)
                    {
                        if (Input.GetKey(KeyCode.E))
                        {
                            //�֐��Ăяo���A�G���[���⋓�������������ꍇ�ꎞ����
                            havescript2.GetComponent<GreenAn>().AnotherColorChange2P();
                            havescript1.GetComponent<RedAn>().AnotherNoColorChange();
                            havescript3.GetComponent<Roller>().SilentPosition();
                            awake = false;
                            ANseconds = 0;
                        }
                    }
                }
                else if (awake == false)
                {
                    ANseconds += Time.deltaTime;
                    if (ANseconds >= 0.75)
                    {
                        if (Input.GetKey(KeyCode.E))
                        {
                            //�֐��Ăяo���A�G���[���⋓�������������ꍇ�ꎞ����
                            havescript1.GetComponent<RedAn>().AnotherColorChange();
                            havescript2.GetComponent<GreenAn>().AnotherNoColorChange2P();
                            havescript3.GetComponent<Roller>().ActionPosition();
                            awake = true;
                            ANseconds = 0;
                        }
                    }
                }
            }
        }
    }

    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.name == "Target")
        {
            if (who.gameObject.activeInHierarchy)
            {
                Debug.Log("�l�����ꂽ");
                ANseconds = 0;
                //�֐��Ăяo���A�G���[���⋓�������������ꍇ�ꎞ����
                //havescript1.GetComponent<Red>().ColorChange();
                //havescript2.GetComponent<Green>().NoColorChange2P();
            }
        }
    }
}

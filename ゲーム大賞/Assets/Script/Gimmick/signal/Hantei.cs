using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hantei : MonoBehaviour
{
    GameObject havescript1;//�ʂ�sc����֐����Ă�
    GameObject havescript2;
    public GameObject havescript3;

    public GameObject who;
    bool awake;

    public float seconds;//�������N�[���^�C��

    // Start is called before the first frame update
    void Start()
    {
        havescript1 = GameObject.Find("red");
        havescript2 = GameObject.Find("green");
        havescript3 = GameObject.Find("wall");
        awake = false;
        havescript1.GetComponent<Red>().ColorChange();
        havescript2.GetComponent<Green>().NoColorChange2P();
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
                    seconds += Time.deltaTime;
                    if (seconds >= 0.5)
                    {
                        

                        if (Input.GetKey(KeyCode.E))
                        {
                            //�֐��Ăяo���A�G���[���⋓�������������ꍇ�ꎞ����
                            havescript2.GetComponent<Green>().ColorChange2P();
                            havescript1.GetComponent<Red>().NoColorChange();
                            havescript3.GetComponent<wall>().WallAlfaCri();
                            awake = false;
                            seconds = 0;
                        }
                    }
                }
                else if (awake == false)
                {
                    seconds += Time.deltaTime;
                    if (seconds >= 0.5)
                    {
                        if (Input.GetKey(KeyCode.E))
                        {
                            //�֐��Ăяo���A�G���[���⋓�������������ꍇ�ꎞ����
                            havescript1.GetComponent<Red>().ColorChange();
                            havescript2.GetComponent<Green>().NoColorChange2P();
                            havescript3.GetComponent<wall>().WallAlfaDes();
                            awake = true;
                            seconds = 0;
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
                //�֐��Ăяo���A�G���[���⋓�������������ꍇ�ꎞ����
                //havescript1.GetComponent<Red>().ColorChange();
                //havescript2.GetComponent<Green>().NoColorChange2P();
                seconds = 0;
            }
        }
    }
}

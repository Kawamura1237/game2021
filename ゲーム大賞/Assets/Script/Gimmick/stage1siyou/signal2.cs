using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class signal2 : MonoBehaviour
{
    
    public GameObject who;
    public GameObject me;
    public GameObject child;
    public GameObject child2;

    bool touch=false;

    GameObject HanB;
    Hantei_B SignalBox;
    GameObject HanC;
    Hantei_C SignalBox2;
    public float seconds;//�������N�[���^�C��

    // Start is called before the first frame update
    void Start()
    {
        HanB = GameObject.Find("Hantei"); 
        SignalBox = HanB.GetComponent<Hantei_B>();
        HanC = GameObject.Find("Hantei_Roll");
        SignalBox2 = HanC.GetComponent<Hantei_C>();

        child2.GetComponent<Red>().ColorChange();//�ԃI��
        child.GetComponent<Green>().NoColorChange2P();//�΃I�t
        Debug.Log("Child:" + child.name);//�q�̃��O
    }

    // Update is called once per frame
    void Update()
    {
        if (touch)
        {
            seconds += Time.deltaTime;
            //ChangeSignal();
            me.GetComponent<signal2>().ChangeSignal();
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        touch = true;
        Debug.Log("�������Ă���");
    }

    void OnTriggerExit2D(Collider2D col)
    {
        touch = false;
    }

    void ChangeSignal()
    {
        if (who.gameObject.activeInHierarchy)
        {

            Debug.Log("�l���̈�ɓ����Ă�");
            if (Input.GetKey(KeyCode.E))
            {
                if (seconds >= 0.25)
                {
                    SignalBox.changeFlag();
                    SignalBox2.changeFlag();
                    if (SignalBox.getFlag())
                    {
                        child.GetComponent<Green>().ColorChange2P();//�΃I��
                        child2.GetComponent<Red>().NoColorChange();//�ԃI�t
                        seconds = 0;

                    }

                    else if (!SignalBox.getFlag())
                    {
                        child2.GetComponent<Red>().ColorChange();//�ԃI��
                        child.GetComponent<Green>().NoColorChange2P();//�΃I�t
                        seconds = 0;
                    }

                    if (SignalBox2.getFlag())
                    {

                        child.GetComponent<Green>().ColorChange2P();//�΃I��
                        child2.GetComponent<Red>().NoColorChange();//�ԃI�t
                        seconds = 0;

                    }

                    else if (!SignalBox2.getFlag())
                    {
                        child2.GetComponent<Red>().ColorChange();//�ԃI��
                        child.GetComponent<Green>().NoColorChange2P();//�΃I�t
                        seconds = 0;
                    }

                    
                }
            }

        }
    }
}

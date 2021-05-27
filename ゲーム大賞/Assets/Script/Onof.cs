using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onof : MonoBehaviour
{
    public GameObject human;
    public GameObject animal;
    public GameObject plant;

    public float cool;

    bool Hflag;
    bool Aflag;
    bool Pflag;

    // Start is called before the first frame update
    void Start()
    {
        Hflag = false;
        Aflag = true;
        Pflag = false;

        this.human.SetActive(Hflag);
        this.animal.SetActive(Aflag);
        this.plant.SetActive(Pflag);

    }

    // Update is called once per frame
    void Update()
    {
        if (Hflag == true)
        {
            //Q�L�[������
            if (Input.GetKeyDown(KeyCode.Q))
            {
                //�\������\��
                Hflag = false;
                Aflag = true;
            }
        }

        else if (Aflag == true)
        {
                //Q�L�[������
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    Aflag = false;
                    Pflag = true;
                }   
        }

        else if (Pflag == true)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                    Pflag = false;
                    Hflag = true;
            }
        }

        this.human.SetActive(Hflag);//�l����
        this.animal.SetActive(Aflag);//�����L��
        this.plant.SetActive(Pflag);//�A���L��
    }
}



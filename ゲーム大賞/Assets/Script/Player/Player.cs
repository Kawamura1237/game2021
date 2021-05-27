using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player instance = null;

    public GameObject human;
    public GameObject animal;
    public GameObject plant;

    //public float cool;

    public AudioClip deathSE;

    bool Hflag;
    bool Aflag;
    bool Pflag;

    private int DeathCount = 0;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Hflag = false;
        Aflag = false;
        Pflag = true;

        this.human.SetActive(Hflag);
        this.animal.SetActive(Aflag);
        this.plant.SetActive(Pflag);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            Debug.Log("��͎���");
            PlayerDeath();
        }

        //Q�L�[������
        if (Input.GetKeyDown(KeyCode.Q))
        {
            PlayerReincarnation();
        }

        this.human.SetActive(Hflag);//�l����
        this.animal.SetActive(Aflag);//�����L��
        this.plant.SetActive(Pflag);//�A���L��
    }

    //�]������������������������������������������������������������������������������������������������
    void PlayerReincarnation()
    {
        Debug.Log("�����Ԃ���");

        if (Hflag == true)
        {
            Hflag = false;
            Aflag = true;
        }
        else if (Aflag == true)
        {
            Aflag = false;
            Pflag = true;
        }
        else if (Pflag == true)
        {
            Pflag = false;
            Hflag = true;
        }

        DeathCount += 1;
    }
    //��������������������������������������������������������������������������������������������������

    //���񂾏�������������������������������������������������������������������������������������������
    void PlayerDeath()
    {
        Debug.Log("�]������");
        PlayerReincarnation();

        SE.instance.PlaySE(deathSE);
    }
    //��������������������������������������������������������������������������������������������������

    public int GetDeathCount()
    {
        return DeathCount;
    }

}

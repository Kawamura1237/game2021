using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour
{
    Rigidbody rb;
    bool flag;
    public Texture texture;
    public Texture texture2;
    public Color color;

    //�ړ�����X�N���v�g
    //float speed = 2.0f;
    //Vector3 direction = new Vector3(-29f,-0.5f, 5f);
    //public Vector3 direction;
    //Vector3 down = new Vector3(-29f, -0.5f, 0f);
    //public Vector3 down;

    // Start is called before the first frame update
    void Start()
    {
        flag = false;
        rb = this.GetComponent<Rigidbody>();

        //mr = GetComponent<MeshRenderer>();
        //mr.material.color = mr.material.color - new Color32(0, 0, 0, 255);
        //GetComponent<Renderer>().material.color = new Color32(250, 121, 121, 63);

        GetComponent<BoxCollider>().enabled = false;
        color = GetComponent<Renderer>().material.color;
        GetComponent<Renderer>().material.mainTexture = texture;
        GetComponent<Renderer>().material.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        //if (flag == true)
        //{
        //    WallAlfaCri();
        //}

        //if (flag == false)
        //{
        //    WallAlfaDes();
        //}
    }

    public void Changeee()
    {
        if (flag == true)
        {
            WallAlfaCri();
        }

        if (flag == false)
        {
            WallAlfaDes();
        }
    }

    public void WallAlfaCri()
    {
        //�ړ�����X�N���v�g
        //flag = false ;
        //float step = speed * Time.deltaTime;
        //transform.position = Vector3.MoveTowards(transform.position, direction, step);
        //����������I�u�W�F�N�g
        //GetComponent<Renderer>().material.color = new Color32(250,121,121, 255);

        flag = false;
        GetComponent<Renderer>().material.mainTexture = texture2;
        GetComponent<Renderer>().material.color = Color.white;
        GetComponent<BoxCollider>().enabled = true;
        Debug.Log("�Ǐ����I��");
    }

    public void WallAlfaDes()
    {
        //�ړ�����X�N���v�g
        //flag = true;
        //float step = speed * Time.deltaTime;
        //transform.position = Vector3.MoveTowards(transform.position, down, step);
        //����������X�N���v�g
        //GetComponent<Renderer>().material.color = new Color32(250, 121, 121, 63);

        flag = true;
        GetComponent<Renderer>().material.mainTexture = texture;
        GetComponent<Renderer>().material.color = Color.white;
        GetComponent<BoxCollider>().enabled = false;
        Debug.Log("�Ǐ����I�t");
    }
}

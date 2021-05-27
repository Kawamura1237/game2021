using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human2D : MonoBehaviour
{
    private float speed;
    public float Speed;
    public float jamp;
    Rigidbody2D rb2D;
    bool isFloor = true;

    [SerializeField] private GameObject Player;

    //private Move PlayerAction;
    //Rigidbody2D Brb;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = Player.GetComponent<Rigidbody2D>();  // rigidbody���擾   

        //PlayerAction = Player.GetComponent<Move>();
        //Brb = PlayerAction.rb;

    }

    // Update is called once per frame
    void Update()
    {
        HumanMove();
        HumanJump();
    }

    void HumanMove()
    {
        if (isFloor)
        {
            float x = Input.GetAxis("Horizontal");
            if (x > 0.2 || x < -0.2)
            {
                speed = Speed;
                rb2D.velocity = new Vector2(x * speed, rb2D.velocity.y);//, rb.velocity.z);
                //Debug.Log("�ړ�");
            }
            else
            {
                speed = 0;
            }
        }
    }

    void HumanAction(Collision2D collision)
    {
        if (Input.GetKeyDown("space"))
        {
            //collision.GimmickStart();   //GimmickStart���Ă�
        }
    }


    void HumanJump()
    {
        if (isFloor)
        {
            if (Input.GetKeyDown("space"))
            {
                Vector3 force = new Vector3(0.0f, 8.0f, 0.0f);  // �͂�ݒ�
                rb2D.velocity = new Vector2(rb2D.velocity.x, jamp);//, rb.velocity.z);
                Debug.Log("����!");
            }
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            isFloor = true;
            Debug.Log("���n!");
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            isFloor = true;
            Debug.Log("���n��!");
        }
    }
    

    private void OnCollisionExit2D(Collision2D collision)
    {  //"Floor"�^�O���t���Ă���I�u�W�F�N�g
        if (collision.gameObject.tag == "Floor")
        {
            isFloor = false;
            Debug.Log("����!");
        }
    }

    void GimmickStart()
    {

    }

}

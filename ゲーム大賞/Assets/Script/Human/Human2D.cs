using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human2D : MonoBehaviour
{
    private float speed;
    public float jamp;
    Rigidbody2D rb2D;
    bool isFloor = true;

    [SerializeField] private GameObject Player;

    private Move PlayerAction;
    //Rigidbody2D Brb;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = this.GetComponent<Rigidbody2D>();  // rigidbodyを取得   

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
                speed = 10;
                rb2D.velocity = new Vector2(x * speed, rb2D.velocity.y);//, rb.velocity.z);
                //Debug.Log("移動");
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
            //collision.GimmickStart();   //GimmickStartを呼ぶ
        }
    }


    void HumanJump()
    {
        if (Input.GetKeyDown("space"))
        {
            Vector3 force = new Vector3(0.0f, 8.0f, 0.0f);  // 力を設定
            rb2D.velocity = new Vector2(rb2D.velocity.x, jamp);//, rb.velocity.z);
            Debug.Log("跳んだ!");
        }
    }


    void OnCollision2DStay(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            isFloor = true;
        }
    }
    void OnCollision2DExit(Collision2D collision)
    {  //"Floor"タグが付いているオブジェクト
        if (collision.gameObject.tag == "Floor")
        {
            isFloor = false;
        }
    }

    void GimmickStart()
    {

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beast2D : MonoBehaviour
{
    [SerializeField]private Rigidbody2D rb;
    

    public AudioClip jumpSE;
    private float speed;
    private float gravity;
    private bool isFloor;

    //GameObject Player; //Player����񂻂̂��̂�����ϐ�

    //Move script; //Move������ϐ�

    //Start is called before the first frame update
    void Start()
    {

        //PlayerAction = Player.GetComponent<Move>();

        //Brb = PlayerAction.rb;
        rb = this.GetComponent<Rigidbody2D>();

    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            isFloor = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {  //"Floor"�^�O���t���Ă���I�u�W�F�N�g
        if (collision.gameObject.tag == "Floor")
        {
            isFloor = false;
        }
    }


    void Update()
    {
        //�v���C���[���n�ʂƐڐG���Ă鎞=========================================================================
        if (isFloor)
        {
            //�ڐG������Ԃ�space�L�[�������ꂽ�Ƃ��W�����v--------------------------------
            if (Input.GetKeyDown("space"))
            {
                Vector2 force = new Vector3(0.0f, 6.0f);     // �͂�ݒ�
                rb.AddForce(force, (ForceMode2D)ForceMode.Impulse);// �͂�������
                SE.instance.PlaySE(jumpSE);
                //Debug.Log("����!");
            }

            //-----------------------------------------------------------------------------

            //�v���C���[�̈ړ����x�ύX-----------------------------------------------------
            //float x = Input.GetAxis("Horizontal");
            //if (x > 0.2 || x < -0.2)
            //{
            //    speed = 20;
            //    //PlayerAction.rb.velocity = new Vector3(x * speed, PlayerAction.rb.velocity.y, PlayerAction.rb.velocity.z);
            //}
            //else
            //{
            //    speed = 0;
            //}

            if (Input.GetKey(KeyCode.D))
            {
                speed = 8;
            }
            else if (Input.GetKey(KeyCode.A))
            {
                speed = -8;
            }
            else
            {
                speed = 0.0f;
            }
            rb.velocity = new Vector2(speed, rb.velocity.y);
            //-----------------------------------------------------------------------------
        }
        //==========================================================================================================



        //�v���C���[���󒆂ɂ���Ƃ�================================================================================
        if (!isFloor)
        {

            //----------------------------------------------------------------------------------

            //E�L�[�������Ă�Ԃ�������---------------------------------------------------------
            if (Input.GetKey(KeyCode.E))
            {
                // gravity = -1.0f;  //�l��������Ώd���Ȃ�
                rb.velocity = new Vector2(rb.velocity.x, -0.3f);

                //�󒆂ł̃v���C���[�ړ�-----------------------------------------------------------
                if (Input.GetKey(KeyCode.D))
                {
                    speed = 8;
                }
                else if (Input.GetKey(KeyCode.A))
                {
                    speed = -8;
                }
                else
                {
                    speed = 0.0f;
                }

                rb.velocity = new Vector3(speed, rb.velocity.y);
            }
            //----------------------------------------------------------------------------------
        }
        //============================================================================================================
    }
}
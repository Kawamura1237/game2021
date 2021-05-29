using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beast2D : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;


    public AudioClip jumpSE;
    public AudioClip kakkuuSE;
    private float speed;
    private float gravity;
    private bool isFloor;

    private Animator anim = null;


    //GameObject Player; //Player����񂻂̂��̂�����ϐ�

    //Move script; //Move������ϐ�

    //Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            isFloor = true;
            anim.SetBool("isJamp", false);
            anim.SetBool("isFry", false);
        }
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
            Vector3 scale = transform.localScale;

            //�ڐG������Ԃ�space�L�[�������ꂽ�Ƃ��W�����v--------------------------------
            if (Input.GetKeyDown("space"))
            {
                Vector2 force = new Vector3(0.0f, 10.0f);     // �͂�ݒ�
                rb.AddForce(force, (ForceMode2D)ForceMode.Impulse);// �͂�������
                SE.instance.PlaySE(jumpSE);
                //Debug.Log("����!");

                anim.SetBool("isJamp", true);
                isFloor = false;

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
                speed = 12;
                anim.SetBool("isRun", true);
                scale.x = 80;

            }
            else if (Input.GetKey(KeyCode.A))
            {
                speed = -12;
                anim.SetBool("isRun", true);
                scale.x = -80;

            }
            else
            {
                speed = 0.0f;
                anim.SetBool("isRun", false);
            }

            rb.velocity = new Vector2(speed, rb.velocity.y);
            transform.localScale = scale;
            //-----------------------------------------------------------------------------
        }
        //==========================================================================================================



        //�v���C���[���󒆂ɂ���Ƃ�================================================================================
        if (!isFloor)
        {
            Vector3 scale = transform.localScale;

            //----------------------------------------------------------------------------------

            //E�L�[�������Ă�Ԃ�������---------------------------------------------------------
            if (Input.GetKey(KeyCode.K))
            {
                SE.instance.PlaySE(kakkuuSE);
                anim.SetBool("isFry", true);

                // gravity = -1.0f;  //�l��������Ώd���Ȃ�
                rb.velocity = new Vector2(rb.velocity.x, -0.3f);

                //�󒆂ł̃v���C���[�ړ�-----------------------------------------------------------
                if (Input.GetKey(KeyCode.D))
                {
                    speed = 8;
                    scale.x = 80;
                }
                else if (Input.GetKey(KeyCode.A))
                {
                    speed = -8;
                    scale.x = -80;
                }
                else
                {
                    speed = 0.0f;
                }

                rb.velocity = new Vector3(speed, rb.velocity.y);
            }
            else if (!Input.GetKeyUp(KeyCode.K))
            {
                anim.SetBool("isFry", false);
            }

            transform.localScale = scale;

            //----------------------------------------------------------------------------------
        }
        //============================================================================================================
    }
}
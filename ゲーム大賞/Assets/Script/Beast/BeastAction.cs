using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeastAction : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    private Move PlayerAction;

    public AudioClip jumpSE;

    
    private float speed;
    private float gravity;

    Rigidbody Brb;

    //GameObject Player; //Player����񂻂̂��̂�����ϐ�

    //Move script; //Move������ϐ�

    //Start is called before the first frame update
    void Start()
    {
        PlayerAction = Player.GetComponent<Move>();

        Brb = PlayerAction.rb;


    }

    void Update()
    {
        //�v���C���[���n�ʂƐڐG���Ă鎞=========================================================================
        if (PlayerAction.isFloor)
        {
            //�ڐG������Ԃ�space�L�[�������ꂽ�Ƃ��W�����v--------------------------------
            if (Input.GetKeyDown("space"))
            {
                Vector3 force = new Vector3(0.0f, 6.0f, 0.0f);  // �͂�ݒ�
                PlayerAction.rb.AddForce(force, ForceMode.Impulse);          // �͂�������
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
            PlayerAction.rb.velocity = new Vector3(speed, PlayerAction.rb.velocity.y, PlayerAction.rb.velocity.z);
            //-----------------------------------------------------------------------------
        }
        //==========================================================================================================

     

        //�v���C���[���󒆂ɂ���Ƃ�================================================================================
        if(PlayerAction.isFloor==false)
        {
            
            //----------------------------------------------------------------------------------

            //E�L�[�������Ă�Ԃ�������---------------------------------------------------------
            if (Input.GetKey(KeyCode.E))
            {
                gravity = -1.0f;  //�l��������Ώd���Ȃ�
                PlayerAction.rb.velocity = new Vector3(PlayerAction.rb.velocity.x, PlayerAction.rb.velocity.y*gravity, PlayerAction.rb.velocity.z);

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
                 PlayerAction.rb.velocity = new Vector3(speed, PlayerAction.rb.velocity.y, PlayerAction.rb.velocity.z);
            }
            //----------------------------------------------------------------------------------
        }
        //============================================================================================================
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeastAction : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    private Move PlayerAction;

    
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
                Vector3 force = new Vector3(0.0f, 12.0f, 0.0f);  // �͂�ݒ�
                PlayerAction.rb.AddForce(force, ForceMode.Impulse);          // �͂�������
                //Debug.Log("����!");
            }
            //-----------------------------------------------------------------------------

            //�v���C���[�̈ړ����x�ύX-----------------------------------------------------
            float x = Input.GetAxis("Horizontal");
            if (x > 0.2 || x < -0.2)
            {
                speed = 20;
                PlayerAction.rb.velocity = new Vector3(x * speed, PlayerAction.rb.velocity.y, PlayerAction.rb.velocity.z);
            }
            else
            {
                speed = 0;
            }
            //-----------------------------------------------------------------------------
        }
        //==========================================================================================================

     

        //�v���C���[���󒆂ɂ���Ƃ�================================================================================
        if(PlayerAction.isFloor==false)
        {
            //�󒆂ł̃v���C���[�ړ�-----------------------------------------------------------
            float x = Input.GetAxis("Horizontal");
            if (x > 0.2 || x < -0.2)
            {
                speed = 20;
                PlayerAction.rb.velocity = new Vector3(x * speed, PlayerAction.rb.velocity.y, PlayerAction.rb.velocity.z);
            }
            else
            {
                speed = 0;
            }
            //----------------------------------------------------------------------------------

            //E�L�[�������Ă�Ԃ�������---------------------------------------------------------
            if (Input.GetKey(KeyCode.E))
            {
                gravity = -0.7f;  //�l��������Ώd���Ȃ�
                PlayerAction.rb.velocity = new Vector3(PlayerAction.rb.velocity.x, PlayerAction.rb.velocity.y*gravity, PlayerAction.rb.velocity.z);
            }
            //----------------------------------------------------------------------------------
        }
        //============================================================================================================
    }
}
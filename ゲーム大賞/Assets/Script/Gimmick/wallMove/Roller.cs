using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roller : MonoBehaviour
{

    public float Agi;
    float spe;

    public float Ti;
    public float Su;

    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.Euler(0, Ti, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //if (lie == true)
        //{
        //    ActionPosition();
        //}

        //if (lie == false)
        //{
        //    SilentPosition();
        //}
    }

    public void ActionPosition()
    {
        //Vector3 position = this.transform.localPosition;
        //Quaternion rotation = this.transform.localRotation;
        //Vector3 scale = this.transform.localScale;

        //// �N�H�[�^�j�I�� �� �I�C���[�p�ւ̕ϊ�
        //Vector3 rotationAngles = rotation.eulerAngles;

        //// X����90�x��]
        ////rotationAngles.y = rotationAngles.y + 90.0f;
        //// Vector3�̉��Z�͈ȉ��̂悤�ȏ��������\
        //rotationAngles += new Vector3(0.0f, 180.0f, 0.0f);

        //// �I�C���[�p �� �N�H�[�^�j�I���ւ̕ϊ�
        //rotation = Quaternion.Euler(rotationAngles);

        //// Transform�l��ݒ肷��
        //this.transform.localPosition = position;
        //this.transform.localRotation = rotation;
        //this.transform.localScale = scale;

        transform.rotation = Quaternion.Euler(0, Su, 0);

    }

    public void SilentPosition()
    {
        //Vector3 position = this.transform.localPosition;
        //Quaternion rotation = this.transform.localRotation;
        //Vector3 scale = this.transform.localScale;

        //// �N�H�[�^�j�I�� �� �I�C���[�p�ւ̕ϊ�
        //Vector3 rotationAngles = rotation.eulerAngles;

        //// X����90�x��]
        ////rotationAngles.y = rotationAngles.y - 90.0f;
        //// Vector3�̉��Z�͈ȉ��̂悤�ȏ��������\
        //rotationAngles += new Vector3(0.0f, 90.0f, 0.0f);

        //// �I�C���[�p �� �N�H�[�^�j�I���ւ̕ϊ�
        //rotation = Quaternion.Euler(rotationAngles);

        //// Transform�l��ݒ肷��
        //this.transform.localPosition = position;
        //this.transform.localRotation = rotation;
        //this.transform.localScale = scale;

        transform.rotation = Quaternion.Euler(0, Ti, 0);

    }
}

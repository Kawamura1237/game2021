using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planting : MonoBehaviour
{
    // �픭�˓_
    public GameObject seed;

    // �픭�˓_
    public Transform plantTop;


    // ��̑��x
    public float speed = 250;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // z �L�[�������ꂽ��
        if (Input.GetKeyDown(KeyCode.Space))
        {

            // ��̕���
            GameObject seeds = Instantiate(seed) as GameObject;

            Vector3 force;

            force = new Vector3(0.8f, 1.0f, 0.0f)*speed;

            // Rigidbody�ɗ͂������Ĕ���
            seeds.GetComponent<Rigidbody>().AddForce(force);

            // ��̈ʒu�𒲐�
            seeds.transform.position = new Vector3(plantTop.position.x, plantTop.position.y + 1.0f, plantTop.position.z);
        }
    }
}

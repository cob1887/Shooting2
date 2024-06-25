using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{

    public float enemyMoveSpeed = 5f;
    public GameObject player;



    Vector3 dir; //���������� ����

     //�Ʒ� �������� ��� �̵��ϰ� �ʹ�.
     //�ʿ� ��� : ����, �ӷ�(ũ��)




    void Start()
    {
        //�÷��̾ ���� ����
        dir = player.transform.position - transform.position;
        dir.Normalize(); //����ȭ ���Ѽ� �ӵ��� ����
    }




    void Update()
    {       

        // �Ʒ� ����(���� ��ǥ)
        //Vector3 dir = Vector3.down;
        //Vectro3 dir = new Vector3(0, -1, 0); - ������ǥ
                        

        // p = p0 + vt                     
        transform.position += dir * enemyMoveSpeed * Time.deltaTime;



    }
}

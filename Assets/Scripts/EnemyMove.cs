using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    

    //�ʿ� ��� : ����, �ӷ�(ũ��)
    public float enemyMoveSpeed = 2f;

    public GameObject player;

    public int downRate = 35; // Ȯ�� ����

    Vector3 dir; //���������� ����

     
     

    void Start()
    {
        // Ư�� ���� ������Ʈ�� �������� ���� �Լ�
        player = GameObject.Find("Player");

        // 1. ���� ������ "Player" ��� �̸����� ���� ������Ʈ�� ã�´�.
        // player= GameObject.Fine("Plyaer");

        // 2. ���� ������ PlayerMove ������Ʈ�� ������ �ִ� ������Ʈ�� ã�´�.
        //PlayerMove playerComp = FindObjectOfType<PlayerMove>();
        //player = playerComp.gameObject;

        // 3. ���� ������Ʈ�� ������ �±� �̸����� ���� ���������� ã�´�.
        //player = GameObject.FindGameObjectWithTag("MyPlayer");



        // ������ Ȯ���� ���� �Ʒ��� �Ǵ� �÷��̾� �������� �̵� ������ �����Ѵ�.
        // Ȯ���� ���� ��÷�Ѵ�. -> Ȯ�� ����, 


        // ������ ���ڸ� �ϳ� �̴´�.
        //int myNumber = Random.Range(0, 100);

        //// ����, ���� ���ڰ� downRate ���� ������, ������ �Ʒ��� �����Ѵ�.
        //if(myNumber < downRate)
        //{
        //    dir = Vector3.down;
        //}
        //// �׷��� �ʴٸ�, ������ �÷��̾� ������ �����Ѵ�.
        //else
        //{
        //    dir = player.transform.position - transform.position.normalized;
        //}



        //�÷��̾ ���� �������� �̵�
        dir = player.transform.position - transform.position;  //�÷��̾ ���� ����
        //dir = Vector3.down; �׳� �������θ� ��������
        
        dir.Normalize(); //����ȭ ���Ѽ� �ӵ��� ����

        transform.position += dir * enemyMoveSpeed * Time.deltaTime; // p = p0 * vt

        
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

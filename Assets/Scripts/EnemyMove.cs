using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{

    public float enemyMoveSpeed = 5f;
    public GameObject player;



    Vector3 dir; //전역변수를 선언

     //아래 방향으로 계속 이동하고 싶다.
     //필요 요소 : 방향, 속력(크기)




    void Start()
    {
        //플레이어를 향한 방향
        dir = player.transform.position - transform.position;
        dir.Normalize(); //정규화 시켜서 속도를 조정
    }




    void Update()
    {       

        // 아래 방향(월드 좌표)
        //Vector3 dir = Vector3.down;
        //Vectro3 dir = new Vector3(0, -1, 0); - 월드좌표
                        

        // p = p0 + vt                     
        transform.position += dir * enemyMoveSpeed * Time.deltaTime;



    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    

    //필요 요소 : 방향, 속력(크기)
    public float enemyMoveSpeed = 2f;

    public GameObject player;

    public int downRate = 35; // 확률 변수

    Vector3 dir; //전역변수를 선언

     
     

    void Start()
    {
        // 특정 게임 오브젝트의 방향으로 가는 함수
        player = GameObject.Find("Player");

        // 1. 현재 씬에서 "Player" 라는 이름으로 게임 오브젝트를 찾는다.
        // player= GameObject.Fine("Plyaer");

        // 2. 현재 씬에서 PlayerMove 컴포넌트를 가지고 있는 오브젝트를 찾는다.
        //PlayerMove playerComp = FindObjectOfType<PlayerMove>();
        //player = playerComp.gameObject;

        // 3. 게임 오브젝트에 설정된 태그 이름으로 게임 오브젝으를 찾는다.
        //player = GameObject.FindGameObjectWithTag("MyPlayer");



        // 지정된 확률에 따라 아래로 또는 플레이어 방향으로 이동 방향을 결정한다.
        // 확률에 따라 추첨한다. -> 확률 변수, 


        // 랜덤한 숫자를 하나 뽑는다.
        //int myNumber = Random.Range(0, 100);

        //// 만일, 뽑은 숫자가 downRate 보다 작으면, 방향을 아래로 설정한다.
        //if(myNumber < downRate)
        //{
        //    dir = Vector3.down;
        //}
        //// 그렇지 않다면, 방향을 플레이어 쪽으로 설정한다.
        //else
        //{
        //    dir = player.transform.position - transform.position.normalized;
        //}



        //플레이어를 향한 방향으로 이동
        dir = player.transform.position - transform.position;  //플레이어를 향한 방향
        //dir = Vector3.down; 그냥 직선으로만 내려갈때
        
        dir.Normalize(); //정규화 시켜서 속도를 조정

        transform.position += dir * enemyMoveSpeed * Time.deltaTime; // p = p0 * vt

        
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

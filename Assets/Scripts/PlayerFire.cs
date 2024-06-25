using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject firePosition;
    //public GameObject firepositions;
    

    public int bulletCount = 2;


    void Start()
    {
        




    }



    void Update()
    {
        // 1. 사용자가 마우스 왼쪽 버튼을 누르는지 확인한다.
        if (Input.GetMouseButtonDown(0))
        {
            // 2. 총알을 생성한다.
                //        firePosition.Length 를 써도된다. 
            {

                GameObject go = Instantiate(bulletPrefab); //복제를 하겠다. 총알
                                                           //GameObject go2 = Instantiate(bulletPrefab); //복제를 하겠다.



                go.transform.position = firePosition.transform.position;

                // 3. 총알을 총구로 옮긴다
                //3-1 총구를 게임 오브젝트 변수로 직접 지정하는 방법

                //go.transform.position = firePosition[i].transform.position;

                //3-2 플레이어의 위치에서 위로 1.5미터 지점을 지정하는 방법
                Vector3 firePos = transform.position + new Vector3(0, 1.5f, 0);
                go.transform.position = firePos;

           //go2.transform.position = firePosition2.transform.position;


        }
        }


    }
}

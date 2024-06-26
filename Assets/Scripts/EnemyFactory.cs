using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory : MonoBehaviour
{
    // ������ �ð��� �� ������ ���ʹ̸� �����Ѵ�.
    // ���� �ð�, ���ʹ� ������(GameObject), ����Ƚð��� �����ð��� �����߳�(���ǹ�) 

    public GameObject enemyPrefab;
    public float delayTime = 3.0f;

    float currentTime = 0;
    float printTime = 1.0f;
    int timeCount = 3;
    bool isTimerStart = true;
 
    
    

    void Start()
    {

    }

    void Update()
    {
        currentTime += Time.deltaTime;



        if (currentTime > delayTime)
        {
            //���ʹ̸� �����Ѵ�.
            GameObject enemy = Instantiate(enemyPrefab);
            enemy.transform.position = transform.position;

           // ��� �ð��� �ٽ� 0���� �ʱ�ȭ �Ѵ�.
           currentTime = 0;

        }

        #region bool �� ����� Ÿ�̸�
        // ����� �ð��� ���� 3 2 1 start�� ����Ѵ�.

        // 3�ʺ��� ī��Ʈ �ٿ��� �����Ѵ�.
        // ��, �� 1�ʸ��� ���� �ð��� ����Ѵ�.
        // ���������� "Start"�� ����Ѵ�.
        // ���� �ð��� 0�ʰ� �Ǹ� ī��Ʈ�� �ߴ��Ѵ�.

        //    if (isTimerStart)
        //    {
        //        printTime = 3;
        //        StartTimer();


        //    }




        //    void StartTimer()
        //    {
        //        currentTime += Time.deltaTime;
        //        if (currentTime > printTime)
        //        {
        //            if (timeCount == 0)
        //            {
        //                print("Start!");
        //                isTimerStart = false;
        //                //currentTime = 0;
        //                //printTime = 0;
        //            }
        //            else
        //            {
        //                print(timeCount);
        //            }
        //            timeCount--;

        //            currentTime = 0;
        //        }
        //}

        #endregion




    }
}

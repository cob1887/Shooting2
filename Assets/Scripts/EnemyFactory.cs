using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory : MonoBehaviour
{
    // ������ �ð��� �� ������ ���ʹ̸� �����Ѵ�.
    // ���� �ð�, ���ʹ� ������, ����� �ð�

    public GameObject enemyPrefab;
    public float delayTime = 2.0f;

    float currentTime = 0;
    float printTime = 1.0f;
    int timeCount = 3;

    void Start()
    {
        // Invoke �Լ��� �̿��� Ÿ�̸� ���
        // 1ȸ�� Ÿ�̸�
        //Invoke("InvokeTest", 2.5f);

        // �ݺ� Ÿ�̸�
        //InvokeRepeating("InvokeTest", 3.0f, 1.0f);
        // Invoke �Լ��� �Ű������� ���� �Լ��� ��� �����ϴ�!
    }

    void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime > delayTime)
        {
            // ���ʹ̸� �����Ѵ�.
            GameObject enemy = Instantiate(enemyPrefab);
            enemy.transform.position = transform.position;

            // ��� �ð��� �ٽ� 0���� �ʱ�ȭ�Ѵ�.
            currentTime = 0;
        }

        #region 3�� ī��Ʈ ��� ���� ����
        // 3�ʺ��� ī��Ʈ �ٿ��� �����Ѵ�.
        // ��, �� 1�ʸ��� ���� �ð��� ����Ѵ�.
        // ���������� "Start"�� ����Ѵ�.
        // ���� �ð��� 0�ʰ� �Ǹ� ī��Ʈ�� �ߴ��Ѵ�.

        //if (isTimerStart)
        //{
        //    printTime = 3;
        //    StartTimer();
        //}
        #endregion




    }

    void StartTimer()
    {
        currentTime += Time.deltaTime;
        if (currentTime > printTime)
        {
            if (timeCount == 0)
            {
                print("Start!");
            }
            else
            {
                print(timeCount);
            }

            timeCount--;
            currentTime = 0;
        }
    }

    void InvokeTest()
    {
        print("�κ�ũ ��� �ǽ�!");
    }
}

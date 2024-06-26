using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory : MonoBehaviour
{
    // ������ �ð��� �� ������ ���ʹ̸� �����Ѵ�.
    // ���� �ð�, ���ʹ� ������(GameObject), ����Ƚð��� �����ð��� �����߳�(���ǹ�) 

    public GameObject enemyPrefab;
    public float delayTime = 2.0f;

    float currentTime = 0;


    void Start()
    {
        
    }

    void Update()
    {
        currentTime += Time.deltaTime;

        if(currentTime > delayTime)
        {
            // ���ʹ̸� �����Ѵ�.
            GameObject enemy = Instantiate(enemyPrefab);
            enemy.transform.position = transform.position;

        }
    }
}

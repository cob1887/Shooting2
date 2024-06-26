using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory : MonoBehaviour
{
    // 지정한 시간이 될 때마다 에너미를 생성한다.
    // 지정 시간, 에너미 프리팹(GameObject), 경과된시간이 지정시간에 도달했냐(조건문) 

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
            // 에너미를 생성한다.
            GameObject enemy = Instantiate(enemyPrefab);
            enemy.transform.position = transform.position;

        }
    }
}

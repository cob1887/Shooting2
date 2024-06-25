using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public float bulletSpeed = 0.7f;
    public float moveSpeed = 10f;

    void Start()
    {
        
    }

    void Update()
    {
        // 위로 계속 이동하고 싶다.
        // 방향: 위로, 이동 속력: float, public
        // 이동 공식: p = p0 + vt , p += vt
        transform.position += Vector3.up * bulletSpeed * Time.deltaTime;
        // transform.position += new Vector3(0, 1, 0) * bulletSpeed * Time.deltaTime;


        //월드 방향
        Vector3 worldDir = Vector3.up;
        //Vector3 worldDir = Vector3.up * -1; 을하면 아래로 간다.

        //로컬 방향(나를 기준)
        Vector3 localDir = transform.up;

        transform.position += localDir * moveSpeed * Time.deltaTime;

    }
}

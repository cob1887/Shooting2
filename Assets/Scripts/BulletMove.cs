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
        // ���� ��� �̵��ϰ� �ʹ�.
        // ����: ����, �̵� �ӷ�: float, public
        // �̵� ����: p = p0 + vt , p += vt
        transform.position += Vector3.up * bulletSpeed * Time.deltaTime;
        // transform.position += new Vector3(0, 1, 0) * bulletSpeed * Time.deltaTime;


        //���� ����
        Vector3 worldDir = Vector3.up;
        //Vector3 worldDir = Vector3.up * -1; ���ϸ� �Ʒ��� ����.

        //���� ����(���� ����)
        Vector3 localDir = transform.up;

        transform.position += localDir * moveSpeed * Time.deltaTime;

    }
}

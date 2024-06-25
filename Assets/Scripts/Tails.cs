using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tails : MonoBehaviour
{
    public GameObject target;

    public int traceSpeed = 15;
   

    void Start()
    {
        
    }




    void Update()
    {
        // Ÿ���� �Ѿư��� �ʹ�.
        // 1.Ÿ��(Game Object)�� �����Ѵ�.
        // 2.Ÿ���� ���� ������ ����Ѵ�.
        Vector3 dir = target.transform.position - transform.position;
        dir.Normalize();

        // 3.���� ����� ������ �ӷ����� �̵��Ѵ�. 
        transform.position += dir * traceSpeed * Time.deltaTime; // p = p0 * vt

    }
}

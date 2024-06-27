using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using Unity.VisualScripting;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public float moveSpeed = 10;
    public GameObject player;

    public float lifeSpan = 5.0f;
    public float currenttime = 0;
    


    void Start()
    {

    }

    void Update()
    {
        // ���� ��� �̵��ϰ� �ʹ�.
        // ����: ����, �̵��ӷ�: float, public
        // �̵� ����: p = p0 + vt , p += vt

        // ���� ����
        Vector3 worldDir = Vector3.up;

        // ���� ����(���� ����)
        Vector3 localDir = transform.up;

        transform.position += localDir * moveSpeed * Time.deltaTime;
        //transform.position += new Vector3(0, 1, 0) * moveSpeed * Time.deltaTime;



        //���� �ð��� ����
        currenttime += Time.deltaTime;
        // �������� 5�ʰ� ������
        if (lifeSpan < currenttime)
        {
         // �����θ� �ı��Ѵ�.
            Destroy(gameObject); // ������� ���� ������Ʈ�� ������ �ҹ��� gameObject(��)�� ǥ��
        }

        lifeSpan -= Time.deltaTime;
        if (lifeSpan < 0)
        {
            Destroy(gameObject);
        }





    }

    // ������ �浹�� �߻����� �� ����Ǵ� �̺�Ʈ �Լ�
    private void OnCollisionEnter(Collision collision)
    {
        // �浹�� ���� ������Ʈ�� �����Ѵ�.
        Destroy(collision.gameObject);

        // ���� �����Ѵ�.
        Destroy(gameObject);
    }

    // ������ �浹 ���� �浹 ������ ���� �� ����Ǵ� �̺�Ʈ �Լ�
    private void OnTriggerEnter(Collider col)
    {
        // �浹�� ���� ������Ʈ�� �����Ѵ�.
        EnemyMove enemy = col.gameObject.GetComponent<EnemyMove>();

        // enemy ������ ���� �ִٸ�...
        if (enemy != null)
        {
            Destroy(col.gameObject);

            // �÷��̾� ���� ������Ʈ�� �پ��ִ� PlayerFire ������Ʈ�� �����´�.
            PlayerFire playerFire = player.GetComponent<PlayerFire>();

            // PlayerFire ������Ʈ�� �ִ� PlayExplotionSound �Լ��� �����Ѵ�.
            playerFire.PlayExplosionSound();
        }

        // ���� �����Ѵ�.
        Destroy(gameObject);
    }


    
    
}

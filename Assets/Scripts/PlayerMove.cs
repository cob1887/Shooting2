using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // �÷��̾ ���ϴ� �������� �̵��Ѵ�.
    // ����, �ӷ� = �ӵ�(Vector)

    public float moveSpeed = 0.1f;
    //Vector3 direction;

    // ó�� �����Ǿ��� �� �� ���� ����Ǵ� �Լ�
    void Start()
    {

    }

    // �� �����Ӹ��� �ݺ��ؼ� �����ϴ� �Լ�
    void Update()
    {
        #region �̵� ���� ���� ���
        //Vector3 direction = new Vector3(1, 1, 0);
        //transform.position += Vector3.right * moveSpeed;
        //transform.position += direction * moveSpeed;

        //print(transform.position);
        #endregion

        // ������� �Է� �ޱ�
        //float h = Input.GetAxis("Horizontal");
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(h, v, 0);
        // ������ ���̸� ������ 1�� �ٲ۴�.(����ȭ)
        direction.Normalize();

        // �̵� ����: p = p0 + vt
        transform.position += direction * moveSpeed * Time.deltaTime;
        //transform.eulerAngles += direction * moveSpeed * Time.deltaTime;
        //transform.localScale += direction * moveSpeed * Time.deltaTime;

        #region ������� Ű �Է� �̺�Ʈ �Լ���
        // Ư�� Ű�� �Է����� �� ����ϴ� �Լ�(Get, GetDown, GetUp)
        //bool value = Input.GetButton("Horizontal");

        //if(Input.GetKey(KeyCode.F1))
        //{
        //    print("F1 Ű�� �������ϴ�!");
        //}
        #endregion

    }
}

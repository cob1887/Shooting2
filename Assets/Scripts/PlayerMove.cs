using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // �÷��̾ ���ϴ� �������� �̵��Ѵ�.
    // ����, �ӷ� = �ӵ� (Vector)

    public float moveSpeed = 0.1f;
    Vector3 direction;

    // ����ڰ� ���콺 ���� ��ư�� ������ �Ѿ��� �ѱ��� �����ǰ� �ϰ�ʹ�.
    
    // 2. �Ѿ��� �����Ѵ�.
    // 3. �Ѿ��� �ѱ��� �ű��   

    // ó�� �����Ǿ��� �� �� ���� ����Ǵ� �Լ�
    void Start()
    {
        // transform.position += Vector3.right;
    }

    // �� �����Ӹ��� �ݺ��ؼ� �����ϴ� �Լ�
    void Update()
    {
        #region �̵� ���� ���� ���
        // �̵� ����: p = p0 + vt


        // Vector3 direction =  new Vector3(1, 1, 0);
        // transform.position += Vector3.right * moveSpeed;
        // transform.position += direction * moveSpeed;

        // print(transform.position);

        // ������� �Է� �ޱ�
        // float h = Input.GetAxis("Horizontal");
        float h = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(h, z, 0);

        // ������ ���̸� ������ 1�� �ٲ۴�. (����ȭ)
        direction.Normalize();

        transform.position += direction * moveSpeed * Time.deltaTime;

        // transform.eulerAngles += direction * moveSpeed * Time.deltaTime;
        // transform.localScale += direction * moveSpeed * Time.deltaTime;

        // Ư�� Ű�� �Է����� �� ����ϴ� �Լ�(Get, GetDown, GetUp)
        // bool value = Input.GetButton("Horizontal");

        // if(Input.GetKey(KeyCode.F1))
        // {
        //    print("F1 Ű�� �������ϴ�!");
        // }

        #endregion

        #region Ű �Է� �̺�Ʈ
       

        


        #endregion
    }
}

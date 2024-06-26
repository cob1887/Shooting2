using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject firePosition;
    //public GameObject firepositions;
    public AudioSource audioSource;


    public int bulletCount = 2;


    void Start()
    {
        audioSource.volume = 0.2f;




    }



    void Update()
    {
        // 1. ����ڰ� ���콺 ���� ��ư�� �������� Ȯ���Ѵ�.
        if (Input.GetMouseButtonDown(0))
        {
            // 2. �Ѿ��� �����Ѵ�.
                //         firePosition.Length �� �ᵵ�ȴ�. 
            {

                GameObject go = Instantiate(bulletPrefab); //������ �ϰڴ�. �Ѿ�
                                                           //GameObject go2 = Instantiate(bulletPrefab); //������ �ϰڴ�.



                //go.transform.position = firePosition.transform.rotation;

                // 3. �Ѿ��� �ѱ��� �ű��
                //3-1 �ѱ��� ���� ������Ʈ ������ ���� �����ϴ� ���
                go.transform.position = firePosition.transform.position;
                go.transform.rotation = firePosition.transform.rotation;

                //go.transform.position = firePosition[i].transform.position;

                //3-2 �÷��̾��� ��ġ���� ���� 1.5���� ������ �����ϴ� ���
                Vector3 firePos = transform.position + new Vector3(0, 1.5f, 0);
                go.transform.position = firePos;


                //�Ѿ� �߻����� �����Ѵ�.
                audioSource.Play();
                //audioSource.Stop();
                //audioSource.Pause();

                

           


        }
        }


    }
}

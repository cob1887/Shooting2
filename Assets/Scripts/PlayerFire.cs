using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject firePosition;
    //public GameObject[] firePositions;

    public AudioClip[] sounds;

    AudioSource audioSource;

    void Start()
    {
        // AudioSource ������Ʈ�� �������� ���
        audioSource = transform.GetComponent<AudioSource>();



    }

    void Update()
    {
        // ����ڰ� ���콺 ���� ��ư�� ������ �Ѿ��� �ѱ��� �����ǰ� �ϰ� �ʹ�!
        // 1. ����ڰ� ���콺 ���� ��ư�� �������� Ȯ���Ѵ�.
        if (Input.GetMouseButtonDown(0))
        {
            // 2. �Ѿ��� �����Ѵ�.
            GameObject go = Instantiate(bulletPrefab);

            // 3. ������ �Ѿ��� �ѱ��� �ű��.
            // 3-1. �ѱ��� ���� ������Ʈ ������ ���� �����ϴ� ���
            go.transform.position = firePosition.transform.position;
            go.transform.rotation = firePosition.transform.rotation;
            // 3-2. �÷��̾��� ��ġ���� ���� 1.5���� ������ �����ϴ� ���
            //Vector3 firePos = transform.position + new Vector3(0, 1.5f, 0);
            //go.transform.position = firePos;

            // 4. ������ �Ѿ��� BulletMove ������Ʈ�� �ִ� Player ������ �ڱ� �ڽ��� �ִ´�.
            go.GetComponent<BulletMove>().player = gameObject;


            // �Ѿ� �߻����� �����Ѵ�.
            audioSource.clip = sounds[0];
            audioSource.volume = 0.2f;
            audioSource.Play();
            //audioSource.Stop();
            //audioSource.Pause();

        }

        #region �� �� �̻� �Ѿ��� �߻��� ���
        //if (Input.GetMouseButtonDown(0))
        //{
        //    for (int i = 0; i < firePosition.Length; i++)
        //    {
        //        // 2. �Ѿ��� �����Ѵ�.
        //        GameObject go = Instantiate(bulletPrefab);

        //        // 3. ������ �Ѿ��� �ѱ��� �ű��.
        //        go.transform.position = firePositions[i].transform.position;
        //    }
        //}
        #endregion

    }

    // ���� ȿ������ �÷����ϴ� �Լ�
    public void PlayExplosionSound()
    {
        audioSource.clip = sounds[1];
        audioSource.volume = 1.0f;
        audioSource.Play();
    }

}

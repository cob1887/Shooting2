using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMusic : MonoBehaviour
{
    public AudioClip[] soundClips;
    //AudioClip[] soundClips = new AudioClip[3]; ���� public �̶� ��������

    AudioSource musicPlayer;

    void Start()
    {
        musicPlayer = GetComponent<AudioSource>(); // �����  �ҽ� ������Ʈ�� ������ ĳ���Ѵ�

    }

    void Update()
    {
        // ���� Ű������ ���� Ű 1���� ������, 
        //if (Input.GetKeyDown(KeyCode.Alpha1))
        if(Input.GetButtonDown("Alpha1"))
        {
            //���� Ŭ�� �迭�� 0�� ���� ������ �����Ѵ�.            
            ChangeSoundClip(0);
        }

        // �׷��� �ʰ� ����, Ű������ ���� Ű 2���� ������,
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            // ���� Ŭ�� �迭�� 1�� ���� ������ �����Ѵ�.

            //musicPlayer.Stop();
            //musicPlayer.clip = soundClips[1];
            //musicPlayer.Play();
            ChangeSoundClip(1);
        }
        // �׷��� �ʰ� ����, Ű������ esc Ű�� ������
        else if(Input.GetKeyDown(KeyCode.Escape))
        {
            musicPlayer.Stop();
        }


    }
    void ChangeSoundClip(int clipNumber)
    {       
        
            //���� Ŭ�� �迭�� 0�� ���� ������ �����Ѵ�.
            // 1. ���� ���� ����� �ҽ��� �����Ѵ�.
            musicPlayer.Stop();

            // 2. ���� �迭���� 0��°�� ����� �ҽ��� �ִ´�
            musicPlayer.clip = soundClips[clipNumber];

            // 3. ����� �ҽ��� �÷��� �Ѵ�. 
            musicPlayer.Play();

        
    }
}


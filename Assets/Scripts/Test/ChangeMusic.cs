using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMusic : MonoBehaviour
{
    public AudioClip[] soundClips;
    //AudioClip[] soundClips = new AudioClip[3]; 위는 public 이라 생략가능

    AudioSource musicPlayer;

    void Start()
    {
        musicPlayer = GetComponent<AudioSource>(); // 오디오  소스 컴포넌트를 변수에 캐싱한다

    }

    void Update()
    {
        // 만일 키보드의 숫자 키 1번을 누르면, 
        //if (Input.GetKeyDown(KeyCode.Alpha1))
        if(Input.GetButtonDown("Alpha1"))
        {
            //사운드 클립 배열의 0번 음원 파일을 실행한다.            
            ChangeSoundClip(0);
        }

        // 그렇지 않고 만일, 키보드의 숫자 키 2번을 누르면,
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            // 사운드 클립 배열의 1번 음원 파일을 실행한다.

            //musicPlayer.Stop();
            //musicPlayer.clip = soundClips[1];
            //musicPlayer.Play();
            ChangeSoundClip(1);
        }
        // 그렇지 않고 만일, 키보드의 esc 키를 누르면
        else if(Input.GetKeyDown(KeyCode.Escape))
        {
            musicPlayer.Stop();
        }


    }
    void ChangeSoundClip(int clipNumber)
    {       
        
            //사운드 클립 배열의 0번 음원 파일을 실행한다.
            // 1. 실행 중인 오디오 소스를 정지한다.
            musicPlayer.Stop();

            // 2. 음원 배열에서 0번째를 오디오 소스에 넣는다
            musicPlayer.clip = soundClips[clipNumber];

            // 3. 오디오 소스를 플레이 한다. 
            musicPlayer.Play();

        
    }
}


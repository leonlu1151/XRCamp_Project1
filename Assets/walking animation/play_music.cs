using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play_music : MonoBehaviour
{
    public AudioClip music;
    public GameObject dad;
    public GameObject point8;
    private AudioSource back;
    void Start()
    {
        back = this.GetComponent<AudioSource>();
        back.loop = true; //設置循環播放  
        back.volume = 0.3f;//設置音量最大，區間在0-1之間
        back.clip = music;
        back.Play(); //播放背景音樂，
    }

    void Update()
    {
        if (dad.transform.position.x == point8.transform.position.x && dad.transform.position.z == point8.transform.position.z)
        {
            if (back.volume - 0.1f >= 0)
            {
                back.volume -= 0.1f;
            }
            else
            {
                back.volume = 0;
            }
            
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitAndDisappear : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 move;
    AudioSource back;
    public AudioClip hit_music;

    void Start()
    {
        move = gameObject.transform.position;
        back = gameObject.GetComponent<AudioSource>();
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "arcade")
        {
            gameObject.transform.position = move;
            back.loop = false; //設置循環播放  
            back.volume = 0.6f;//設置音量最大，區間在0-1之間
            back.clip = hit_music;
            back.Play(); //播放背景音樂
        }
    }
}

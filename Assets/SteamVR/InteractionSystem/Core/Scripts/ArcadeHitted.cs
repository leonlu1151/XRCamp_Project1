using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ArcadeHitted : MonoBehaviour
{
    GameObject sc;
    GameObject sc1;
    GameObject sc2;
    AudioSource back;
    VideoPlayer videoPlayer;
    VideoPlayer videoPlayer1;
    VideoPlayer videoPlayer2;

    Vector3 move;

    private int dish_count;
    private bool yesorno;

    GameObject gacha;
    GameObject fish;
    GameObject hands;
    GameObject feet;
    GameObject monster1;
    GameObject monster2;
    public GameObject dad;
    public GameObject mom;
    private int gacha_count;
    public AudioClip win_music;
    public AudioClip loose_music;
    public AudioClip hit_music;
    

    void Start()
    {
        sc = gameObject.transform.GetChild(12).gameObject;
        sc1 = gameObject.transform.GetChild(18).gameObject;
        sc2 = gameObject.transform.GetChild(19).gameObject;

        gacha = gameObject.transform.GetChild(22).gameObject;
        hands = gameObject.transform.GetChild(23).gameObject;
        feet = gameObject.transform.GetChild(24).gameObject;
        fish = gameObject.transform.GetChild(25).gameObject;
        monster1 = gameObject.transform.GetChild(26).gameObject;
        monster2 = gameObject.transform.GetChild(27).gameObject;

        move = gacha.transform.position;

        dish_count = 1;
        yesorno = true;
        back = gameObject.GetComponent<AudioSource>();
        gacha.SetActive(false);
        videoPlayer = sc.GetComponent<VideoPlayer>();
        videoPlayer1 = sc1.GetComponent<VideoPlayer>();
        videoPlayer2 = sc2.GetComponent<VideoPlayer>();
        gacha_count = 0;
    }

    void OnCollisionEnter (Collision collision)
    {
        
        if (collision.gameObject.tag == "dish"  && dish_count < 3)
        {
            sc.SetActive(false);
            videoPlayer1.Play();
            
            dish_count += 1;
            Invoke("Gachabreak", 8.0f);
        }
        
        else if(collision.gameObject.tag == "dish"  && dish_count == 3 )
        {
            sc.SetActive(false);
            sc1.SetActive(false);
            videoPlayer2.Play();
            
            gacha.SetActive(true);
            
            Invoke("Gachabreak", 2.5f);
            gacha_count += 1;
        }
        
    }

    void Gachabreak()
    {

        gacha.SetActive(false);
        if (gacha_count == 1)
        {
            hands.SetActive(true);
        }
        else if (gacha_count == 2)
        {
            feet.SetActive(true);
        }
        else if (gacha_count == 3)
        {
            fish.SetActive(true);
            monster1.SetActive(true);
            monster2.SetActive(true);
            dad.SetActive(false);
            mom.SetActive(false);
        }
    }
    
    
}

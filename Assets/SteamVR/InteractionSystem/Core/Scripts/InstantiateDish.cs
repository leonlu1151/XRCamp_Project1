using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Valve.VR.InteractionSystem.Sample
{

    

    public class InstantiateDish : UIElement
    {

        private AudioSource back;
        public AudioClip music;
        public GameObject dishes;
        
        protected override void OnButtonClick()
        {
            base.OnButtonClick();

            dishes.SetActive(true);
            gameObject.SetActive(false);

            back = this.GetComponent<AudioSource>();
            back.loop = false; //設置循環播放  
            back.volume = 0.8f;//設置音量最大，區間在0-1之間
            back.clip = music;
            back.Play(); //播放背景音樂，
        }

    
    }
}

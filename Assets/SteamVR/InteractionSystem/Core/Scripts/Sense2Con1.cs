using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sense2Con1 : MonoBehaviour
{
    public GameObject next_word;
    public float delay_time;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("NextSentence", delay_time);
    }

    // Update is called once per frame
    public void NextSentence()
    {
        gameObject.SetActive(false);
        next_word.SetActive(true);
    }
}

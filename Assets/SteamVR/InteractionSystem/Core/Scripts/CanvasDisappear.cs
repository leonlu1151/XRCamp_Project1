using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasDisappear : MonoBehaviour
{
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
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalChoice : MonoBehaviour
{
    public float delay_time;
    GameObject button;
    GameObject button1;
    GameObject button2;

    // Start is called before the first frame update
    void Start()
    {
        button = gameObject.transform.GetChild(2).gameObject;
        button1 = gameObject.transform.GetChild(3).gameObject;
        button2 = gameObject.transform.GetChild(4).gameObject;

        Invoke("NextSentence", delay_time);
    }

    // Update is called once per frame
    public void NextSentence()
    {

        button.SetActive(false);
        button2.SetActive(true);
    }
}

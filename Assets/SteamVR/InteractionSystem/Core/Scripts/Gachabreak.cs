using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gachabreak : MonoBehaviour
{
    public GameObject smoke;
    public GameObject hands;
    public GameObject feet;
    Vector3 move;
    private int gacha_count;

    // Start is called before the first frame update
    void Start()
    {
        move = gameObject.transform.position;
        gacha_count = 0;
    }

    void OnCollisionEnter(Collision collision)
    {
        //if (collision.gameObject.tag == "dish" && videoPlayer1.isPlaying == false && dish_count < 3)
        if (collision.gameObject.tag == "Table" )
        {
            Instantiate(smoke, gameObject.transform.position, gameObject.transform.rotation);
            gameObject.transform.position = move;
            gameObject.SetActive(false);
            
            if (gacha_count == 0)
            {
                Invoke("Appearhands", 2.0f);
            }
            else if (gacha_count == 1)
            {
                Invoke("Appearfeet", 2.0f);
            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Appearhands()
    {
        hands.SetActive(true);
    }
    void Appearfeet()
    {
        feet.SetActive(true);
    }
}

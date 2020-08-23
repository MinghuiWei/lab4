using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{

    int i = 0;
	public Renderer rend;

    int number;

    // Start is called before the first frame update
    void Start()
    {
        number = Random.Range(200, 250);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(number);
        Debug.Log("<" + gameObject.name + ">: " + i);
        i++;

        if(gameObject.tag == "Red" && i == 100)
        {
            gameObject.SetActive(false);
        }

        if (gameObject.tag == "Blue" && i == number)
        {
            rend.enabled = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transparent : MonoBehaviour
{
    // variable that helps us change the visibility according to when "space" key is pressed.
    private bool visible = true;

   //public GameObject button;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // first press space -> dissapear
        {
      

            if (visible)
            {
                // accessing the button component unity and changing the visibility to false
                GameObject.Find("button").GetComponent<Renderer>().enabled = false;
                visible = false;
            }
            else
            {
                // accessing the button component unity and changing the visibility to true
                GameObject.Find("button").GetComponent<Renderer>().enabled = true;
                visible = true;
            }
        }
    }
}

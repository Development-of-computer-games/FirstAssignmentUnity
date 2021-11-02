using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pendulum : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Speed of the pendulum")]
    float speed = 1f;
    float timer = 0f;
    int phase = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.fixedDeltaTime;
        if (timer > 1f)
        {
            phase++;
            phase %= 4;            //Keep the phase between 0 to 3.
            timer = 0f;
        }

        switch (phase)
        {
            case 0:
                transform.Rotate(0f, 0f, speed * (1 - timer));  //Speed, from maximum to zero.
                break;
            case 1:
                transform.Rotate(0f, 0f, -speed * timer);       //Speed, from zero to maximum.
                break;
            case 2:
                transform.Rotate(0f, 0f, -speed * (1 - timer)); //Speed, from maximum to zero.
                break;
            case 3:
                transform.Rotate(0f, 0f, speed * timer);        //Speed, from zero to maximum.
                break;
        }
    }
}

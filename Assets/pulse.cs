using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pulse : MonoBehaviour
{
    [SerializeField]
    [Tooltip("size - the vector that will control how big the heart pulse")]
    Vector3 size = new Vector3(0.4f, 0.4f, 0.4f);
    bool isPulse = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

            if (isPulse)
            {
                isPulse = false;
                transform.localScale += size;
            }
            else
            {
                isPulse = true;
                transform.localScale -= size;
            }

    }
  
}

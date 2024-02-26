using System.Collections;
using System.Collections.Generic;
using UnityEngine;



// esta es la clase 
public class cameralook : MonoBehaviour

    
{
    // variables 
    public float mauseSensitivity = 150f;

    public Transform playerbody;

    float xRotation = 0;



    void Start()
    {
        
    }

    void Update()
    {

        float mauseX = Input.GetAxis("Mouse X") * mauseSensitivity * Time.deltaTime;

        float mauseY = Input.GetAxis("Mouse Y") * mauseSensitivity * Time.deltaTime;

        xRotation -= mauseY;

        xRotation = Mathf.Clamp(xRotation, -90, 90);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        playerbody.Rotate(Vector3.up * mauseX);










    }
}

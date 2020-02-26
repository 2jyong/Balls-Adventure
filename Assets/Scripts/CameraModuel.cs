using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraModuel : MonoBehaviour
{
    public Camera mainCamera;
    public float speed;

    void Start()
    {
        
    }

    
    void Update()
    {
        // GetKeyDown 키를 눌렀을 때 한 번 만 동작
        // GetKey     키를 눌렀을 때 계속 동작 = true
        // GetKeyUp   키를 눌렀다 뗏을 때 동작
        if (Input.GetKey(KeyCode.W))
        {
            mainCamera.transform.Translate(0, 0, speed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            mainCamera.transform.Translate(0, 0, -speed);
        }
    }
}

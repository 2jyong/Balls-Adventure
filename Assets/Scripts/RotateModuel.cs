using System;
using System.Collections.Generic;

using UnityEngine;



class RotateModuel : MonoBehaviour
{
    public float speed = 10;
    [SerializeField] private bool isRotate = false;

    private void Update()
    {
        transform.RotateAround(
            Vector3.zero,               // 회전할 대상의 포지션
            Vector3.forward,   // 회전할 대상 축
            speed);                     // 회전 속도
    }



}
   


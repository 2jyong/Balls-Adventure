using System;
using System.Collections.Generic;

using UnityEngine;



class RotateModuel : MonoBehaviour
{
    // 1.   행성계 구현하기
    // 1++  행성계 곡선으로 구현하기
    // 2.   isRotate 구현하기

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
   


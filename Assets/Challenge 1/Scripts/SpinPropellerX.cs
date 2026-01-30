using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float spinSpeed = 1000f;

    // Update is called once per frame
    void Update()
    {
        // 프로펠러를 Z축 기준으로 회전
        transform.Rotate(Vector3.forward * spinSpeed * Time.deltaTime);
    }
}

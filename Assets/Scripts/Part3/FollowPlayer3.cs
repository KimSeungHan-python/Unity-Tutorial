using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer3: MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 10, -30); // 더 멀리, 약간 위에서
    public float followSpeed = 5f; // 카메라 따라가는 속도
    public float rotationSpeed = 5f; // 회전 따라가는 속도

    // Start is called before the first frame update
    void Start()
    {
        // If plane is not assigned in the inspector, try to find it by ta
    }

    // LateUpdate is called after Update - better for camera follow
    void LateUpdate()
    {
        if (player != null)
        {
            // 비행기 옆에서 따라가기
            transform.position = player.transform.position + offset;
            // 카메라가 비행기를 바라보도록 회전 (Y=-90도)
            //transform.rotation = Quaternion.Euler(0, -90, 0);
        }
    }
}
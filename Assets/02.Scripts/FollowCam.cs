using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    public Transform targetTr;
    private Transform camTr;

    // 따라갈 대상으로부터 떨어질 거리
    [Range(2.0f, 20.0f)]
    public float distance = 2.0f;

    // y축 이동 높이
    [Range(0.0f, 10.0f)]
    public float height = 2.0f;

    // 반응속도
    public float damping = 0.1f;

    // 카메라 LookAt Offset
    public float targetOffset = 2.0f;

    private Vector3 velocity = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        camTr = GetComponent<Transform>();
    }


    void LateUpdate()
    {

        // 추적 대상의 뒤쪽으로 distance만큼, 높이를(y축) height만큼 이동
        Vector3 pos = targetTr.position + (-targetTr.forward * distance) + (Vector3.up * height);

        // <부드럽게 이동시키는 방법 1,2>
        // 1. 구면 선형 보간 함수를 사용해 부드럽게 위치 변경하기(주로 회전 로직에 사용)
        //camTr.position = Vector3.Slerp(camTr.position, pos, Time.deltaTime * damping);  // Vector3.Slerp(시작위치, 목표위치, 시간 t)
        // 2. SmoothDamp을 이용한 위치 보간
        camTr.position = Vector3.SmoothDamp(camTr.position, pos, ref velocity, damping);    // Vector3.SmoothDamp(시작위치, 목표위치, 현재속도, 목표위치까지 도달시간)

        // 카메라를 피벗 좌표를 향해 회전
        camTr.LookAt(targetTr.position + (targetTr.up * targetOffset));
    }
}

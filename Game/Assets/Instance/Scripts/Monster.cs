using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Stat
{
    public Stat()
    {
        Debug.Log("Stat 생성");
    }
}

public class Monster : MonoBehaviour
{
    Stat stat;

    // Awake: 스크립트가 실행될 때 단 한 번만 호출, 스크립트가 비활성화되어도 실행되는 이벤트 함수

    private void Awake()
    {
        Debug.Log("Awake");
    }
    
    // OnEnable: 게임 오브젝트가 활성화될 때마다 호출되는 이벤트 함수

    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }

    // Start: 스크립트가 실행될 때 한 번만 호출, 스크립트가 비활성화 상태일 때는 실행되지 않음

    void Start()
    {
        stat = new Stat();
        Debug.Log("Monster 생성");
    }

    // FixedUpdate: Timestep 설정값에 따라 일정 주기로 호출되는 이벤트 함수

    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }

    //Update: 매 프레임마다 호출되는 이벤트 함수이며, 디바이스의 성능이나 최적화 상황에 따라 framerate가 변화하므로 함수 호출 시간이 계속 달라짐

    private void Update()
    {
        Debug.Log("Update");
    }

    //LateUpdate: Update 후에 호출되는 함수

    private void LateUpdate()
    {
        Debug.Log("LateUpdate");
    }

    //OnDisable: 오브젝트가 비활성화되었을 때 호출되는 이벤트 함수

    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }

    //OnDestroy: 게임 오브젝트가 파괴되었을 때 호출되는 이벤트 함수

    private void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }
}

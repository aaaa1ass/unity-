using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Stat
{
    public Stat()
    {
        Debug.Log("Stat ����");
    }
}

public class Monster : MonoBehaviour
{
    Stat stat;

    // Awake: ��ũ��Ʈ�� ����� �� �� �� ���� ȣ��, ��ũ��Ʈ�� ��Ȱ��ȭ�Ǿ ����Ǵ� �̺�Ʈ �Լ�

    private void Awake()
    {
        Debug.Log("Awake");
    }
    
    // OnEnable: ���� ������Ʈ�� Ȱ��ȭ�� ������ ȣ��Ǵ� �̺�Ʈ �Լ�

    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }

    // Start: ��ũ��Ʈ�� ����� �� �� ���� ȣ��, ��ũ��Ʈ�� ��Ȱ��ȭ ������ ���� ������� ����

    void Start()
    {
        stat = new Stat();
        Debug.Log("Monster ����");
    }

    // FixedUpdate: Timestep �������� ���� ���� �ֱ�� ȣ��Ǵ� �̺�Ʈ �Լ�

    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }

    //Update: �� �����Ӹ��� ȣ��Ǵ� �̺�Ʈ �Լ��̸�, ����̽��� �����̳� ����ȭ ��Ȳ�� ���� framerate�� ��ȭ�ϹǷ� �Լ� ȣ�� �ð��� ��� �޶���

    private void Update()
    {
        Debug.Log("Update");
    }

    //LateUpdate: Update �Ŀ� ȣ��Ǵ� �Լ�

    private void LateUpdate()
    {
        Debug.Log("LateUpdate");
    }

    //OnDisable: ������Ʈ�� ��Ȱ��ȭ�Ǿ��� �� ȣ��Ǵ� �̺�Ʈ �Լ�

    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }

    //OnDestroy: ���� ������Ʈ�� �ı��Ǿ��� �� ȣ��Ǵ� �̺�Ʈ �Լ�

    private void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }
}

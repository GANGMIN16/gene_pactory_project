using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlock_effect : MonoBehaviour
{
    void DestroyObj()       //ĳ���� ����� ������ ����Ʈ ����� �ı� (���� �� ��ư���� ���� �ҷ��ͼ� ���� ����)
    {
        //gameObject.SetActive(false);
        Destroy(gameObject);
    }
}

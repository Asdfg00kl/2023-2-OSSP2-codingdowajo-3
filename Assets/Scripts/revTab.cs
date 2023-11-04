using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class revTab : MonoBehaviour
{
    private GameObject reviewWindow;

    private void Start()
    {
        // â ������Ʈ�� ���� ���۷����� ���ɴϴ�.
        reviewWindow = GameObject.Find("reviewTab"); // "WindowObject"�� ������Ʈ�� �̸��Դϴ�. ������ ����ϴ� ������Ʈ�� �̸����� �����ϼ���.
    }

    public void HideWindow()
    {
        // â ������Ʈ�� ��Ȱ��ȭ�Ͽ� ����ϴ�.
        reviewWindow.SetActive(false);
    }

    public void ShowWindow()
    {
        // â ������Ʈ�� Ȱ��ȭ�Ͽ� ���̰� �մϴ�.
        reviewWindow.SetActive(true);
    }
}

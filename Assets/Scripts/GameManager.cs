using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager I;

    //User����
    public static int ShopPoint = 0;// ���� ��ȭ
    public static int BlackHistoryPaper = 0;// �濪�� ����: 'ȸ��' �����

    void Awake()
    {
        I = this;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

}

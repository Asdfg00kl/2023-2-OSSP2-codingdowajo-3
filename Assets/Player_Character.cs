using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Character : MonoBehaviour
{
    //�������� ��ü ������ 6��
    public const int numofitems = 6;
    //�÷��̾�ĳ������ ���� ����. 0�� ����Ʈ
    public static int state_of_player_char = 0;
    //�÷��̾�� Ư�� �������� �ִ����� ��Ÿ�� bool�迭
    public static bool[] haveitems = new bool[numofitems]
    /*                           �Ȱ�         */
        {false,     false,      false, 
    /*               ����                     */
        false,      false,      false};

    //�÷��̾�ĳ���� ����
    public static int UserChar_Level = 1;
    //�÷��̾�ĳ���� ����ġ
    public static int UserChar_Exp = 0;
    //1����ȭ����
    public static bool evolution_1 = false;
    //2����ȭ����
    public static bool evolution_2 = false;
    //�濪�����̰���
    public static int BlackHistoryPaper = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

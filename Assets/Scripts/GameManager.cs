using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager I;

    //User정보
    public static int ShopPoint = 0;// 상점 재화
    public static int BlackHistoryPaper = 0;// 흑역사 종이: '회고' 입장권

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

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BlackHistoryPaper_number : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TextMeshProUGUI>().text = GameManager.BlackHistoryPaper.ToString();
    }
}

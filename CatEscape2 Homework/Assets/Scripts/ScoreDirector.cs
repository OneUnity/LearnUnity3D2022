using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDirector : MonoBehaviour
{
    GameObject Score;
    public GameObject hpGauge;
    public int GetScore;
    // Start is called before the first frame update
    void Start()
    {
        this.Score = GameObject.Find("Score");
        this.hpGauge = GameObject.Find("hpGauge");
    }

    // Update is called once per frame
    void Update()
    {
        this.Score.GetComponent<Text>().text = "���� ����: " + GetScore + "��"; 
    }

    public void IncreaseScore()
    {
        GetScore += 10;
    }
    public void DecreaseScore()
    {
        GetScore -= 20;
    }
}

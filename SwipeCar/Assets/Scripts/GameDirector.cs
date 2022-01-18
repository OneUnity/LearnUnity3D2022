using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject car;
    GameObject flag;
    GameObject distance;
    // Start is called before the first frame update
    void Start()
    {
        this.car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");
        this.distance = GameObject.Find("Distance");
    }

    // Update is called once per frame
    void Update()
    {
        if (this.flag.transform.position.x > this.car.transform.position.x)
        {
            float length = this.flag.transform.position.x - this.car.transform.position.x;
            length -= 1.6f; // 차의 맨 오른쪽과 깃발과 닿을때 0m로 표기하려 한다.
            if (length < 0)
                length = 0; // 거리가 마이너스일 수는 없다.
            if (length > 0)
                this.distance.GetComponent<Text>().text = "목표 지점까지 " + length.ToString("F2") + "m";
            else
                this.distance.GetComponent<Text>().text = "목표 지점에 도착하였습니다!";
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float speed = 0;
    GameObject car;
    void Start()
    {
        this.car = GameObject.Find("car");
    }

    void Update()
    {
        if(Mathf.Abs(car.transform.position.x)<7.6) // 화면을 벗어나지 않았다면
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                this.speed += 0.004f; // 점차 가속
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                this.speed -= 0.004f; // 점차 가속
            }
        }
        else if(car.transform.position.x<-7.6) // 왼쪽 화면을 벗어나려 한다!
        {
            this.speed = 0f;
            if (Input.GetKey(KeyCode.RightArrow)) // 오른쪽으로 가는건 문제없어!
            {
                this.speed += 0.008f; // this.speed=0f;도 함께 실행되어 0.004f로 똑같이 하면 구석에 박혔을 때 더 느리게 나오더라...
            }
            else if (Input.GetKey(KeyCode.LeftArrow)) // 왼쪽으로는 못 가지!
                this.speed = 0f;
        }
        else if (car.transform.position.x > 7.6) // 오른쪽 화면을 벗어나려 한다!
        {
            this.speed = 0f;
            if (Input.GetKey(KeyCode.RightArrow)) // 오른쪽으로는 못 가지!
                this.speed = 0f;
            else if (Input.GetKey(KeyCode.LeftArrow)) // 왼쪽으로 가는건 문제없어!
            {
                this.speed -= 0.008f;
            }
        }

        transform.Translate(this.speed, 0, 0);
        if (this.speed > 0.1f) // 우측 스피드 상한선
            this.speed = 0.1f;
        if (this.speed < -0.1f) // 좌측 스피드 상한선
            this.speed = -0.1f;

        this.speed *= 0.98f;
        if (Mathf.Abs(this.speed) < 0.0001f) // 감속만으로 아예 멈추지 못하므로 멈출 수 있게 설정해봄.
            this.speed = 0f;
    }
}
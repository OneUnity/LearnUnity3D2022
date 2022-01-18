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
        if(Mathf.Abs(car.transform.position.x)<7.6) // ȭ���� ����� �ʾҴٸ�
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                this.speed += 0.004f; // ���� ����
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                this.speed -= 0.004f; // ���� ����
            }
        }
        else if(car.transform.position.x<-7.6) // ���� ȭ���� ����� �Ѵ�!
        {
            this.speed = 0f;
            if (Input.GetKey(KeyCode.RightArrow)) // ���������� ���°� ��������!
            {
                this.speed += 0.008f; // this.speed=0f;�� �Բ� ����Ǿ� 0.004f�� �Ȱ��� �ϸ� ������ ������ �� �� ������ ��������...
            }
            else if (Input.GetKey(KeyCode.LeftArrow)) // �������δ� �� ����!
                this.speed = 0f;
        }
        else if (car.transform.position.x > 7.6) // ������ ȭ���� ����� �Ѵ�!
        {
            this.speed = 0f;
            if (Input.GetKey(KeyCode.RightArrow)) // ���������δ� �� ����!
                this.speed = 0f;
            else if (Input.GetKey(KeyCode.LeftArrow)) // �������� ���°� ��������!
            {
                this.speed -= 0.008f;
            }
        }

        transform.Translate(this.speed, 0, 0);
        if (this.speed > 0.1f) // ���� ���ǵ� ���Ѽ�
            this.speed = 0.1f;
        if (this.speed < -0.1f) // ���� ���ǵ� ���Ѽ�
            this.speed = -0.1f;

        this.speed *= 0.98f;
        if (Mathf.Abs(this.speed) < 0.0001f) // ���Ӹ����� �ƿ� ������ ���ϹǷ� ���� �� �ְ� �����غ�.
            this.speed = 0f;
    }
}
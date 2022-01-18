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
            length -= 1.6f; // ���� �� �����ʰ� ��߰� ������ 0m�� ǥ���Ϸ� �Ѵ�.
            if (length < 0)
                length = 0; // �Ÿ��� ���̳ʽ��� ���� ����.
            if (length > 0)
                this.distance.GetComponent<Text>().text = "��ǥ �������� " + length.ToString("F2") + "m";
            else
                this.distance.GetComponent<Text>().text = "��ǥ ������ �����Ͽ����ϴ�!";
        }
    }
}
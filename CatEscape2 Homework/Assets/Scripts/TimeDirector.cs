using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeDirector : MonoBehaviour
{
    public int min = 0; // �ð����� ��
    public int min2 = 0; // �ð����� ��2
    public int sec = 0; // �ð����� ��
    private float fsec1=-0.5f;
    private float fsec2 = -0.5f;
    private float recovertime = 2.0f;
    public GameObject hpGauge;
    public GameObject ArrowGenerator;
    GameObject time; // �������� Time���� �� �� Time.deltaTime�� ����� ���� ����.
    // Start is called before the first frame update
    void Start()
    {
        this.time = GameObject.Find("Time");
        this.hpGauge = GameObject.Find("hpGauge");
        this.ArrowGenerator = GameObject.Find("ArrowGenerator");
    }

    // Update is called once per frame
    void Update()
    {
        if (this.hpGauge.GetComponent<Image>().fillAmount > 0f)
        {
            fsec1 += 1 * Time.deltaTime;
            sec = Mathf.RoundToInt(fsec1);
            if (this.sec == 60)
            {
                this.fsec1 = -0.5f;
                this.sec = 0;
                this.min += 1;
                this.min2 += 1;
            }
            fsec2 += 1 * Time.deltaTime;
            if(this.fsec2>recovertime)
            {
                this.hpGauge.GetComponent<Image>().fillAmount += 0.005f;
                this.fsec2 = 0;
            }
            if(this.min2==2)
            {
                this.min2 = 0;
                GameObject go = Instantiate(ArrowGenerator) as GameObject; // �̰͵� �����ϴ�...!
            }

        }
        this.time.GetComponent<Text>().text = "�÷��� Ÿ��: " + min.ToString("D2")+ ":" +sec.ToString("D2");
    }
}
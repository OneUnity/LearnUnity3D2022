using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;
    public GameObject hpGauge;
    float span = 1.0f; // ���� �ð�
    float delta = 0; // �ð� ������ ���
    // Start is called before the first frame update
    void Start()
    {
        this.hpGauge = GameObject.Find("hpGauge");
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime; // �������Ӹ��� �ð� ����
        ArrowGenerate();
    }

    public void ArrowGenerate()
    {
        if(this.hpGauge.GetComponent<Image>().fillAmount > 0f)
        {
            if (this.delta > this.span)
            {
                this.delta = 0;
                GameObject go = Instantiate(arrowPrefab) as GameObject; // �������� �ν��Ͻ�ȭ
                int px = Random.Range(-7, 8);
                go.transform.position = new Vector3(px, 7, 0);
            }
        }
    }
}

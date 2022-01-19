using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;
    public GameObject hpGauge;
    float span = 1.0f; // 스폰 시간
    float delta = 0; // 시간 누적에 사용
    // Start is called before the first frame update
    void Start()
    {
        this.hpGauge = GameObject.Find("hpGauge");
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime; // 매프레임마다 시간 누적
        ArrowGenerate();
    }

    public void ArrowGenerate()
    {
        if(this.hpGauge.GetComponent<Image>().fillAmount > 0f)
        {
            if (this.delta > this.span)
            {
                this.delta = 0;
                GameObject go = Instantiate(arrowPrefab) as GameObject; // 프리팹을 인스턴스화
                int px = Random.Range(-7, 8);
                go.transform.position = new Vector3(px, 7, 0);
            }
        }
    }
}

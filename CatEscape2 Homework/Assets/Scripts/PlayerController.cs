using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    GameObject hpGauge;
    GameObject player;
    bool isleftbuttondown;
    bool isrightbuttondown;
    // Start is called before the first frame update
    void Start()
    {
        this.hpGauge = GameObject.Find("hpGauge");
        this.player = GameObject.Find("player");
    }
    void Update()
    {
        if(isleftbuttondown)
        {
            if (this.hpGauge.GetComponent<Image>().fillAmount > 0f)
            {
                if (this.player.transform.position.x > -8)
                    this.player.transform.Translate(-0.12f, 0, 0);
                else
                    this.player.transform.Translate(0, 0, 0);
            }
            else
                this.player.transform.Translate(0, 0, 0);
        }
        if(isrightbuttondown)
        {
            if (this.hpGauge.GetComponent<Image>().fillAmount > 0f)
            {
                if (this.player.transform.position.x < 8)
                    this.player.transform.Translate(0.12f, 0, 0);
                else
                    this.player.transform.Translate(0, 0, 0);
            }
            else
                this.player.transform.Translate(0, 0, 0);
        }
    }
    public void LButtonDown()
    {
        isleftbuttondown = true;
    }
    public void LButtonUp()
    {
        isleftbuttondown = false;
    }
    public void RButtonDown()
    {
        isrightbuttondown = true;
    }
    public void RButtonUp()
    {
        isrightbuttondown = false;
    }
}

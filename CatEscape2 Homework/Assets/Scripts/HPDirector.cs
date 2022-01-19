using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HPDirector : MonoBehaviour
{
    GameObject hpGauge;
    GameObject restartButton;
    GameObject arrowPrefab;
    GameObject hpPercent;
    
    // Start is called before the first frame update
    void Start()
    {
        this.hpGauge = GameObject.Find("hpGauge");
        this.restartButton = GameObject.Find("RestartButton");
        this.arrowPrefab = GameObject.Find("ArrowGenerator");
        this.hpPercent = GameObject.Find("hpPercent");
        restartButton.SetActive(false);
    }
    void Update()
    {
        if(this.hpGauge.GetComponent<Image>().fillAmount <= 0f)
        {
            StopGame();
        }
        this.hpPercent.GetComponent<Text>().text = "³²Àº HP: " + (this.hpGauge.GetComponent<Image>().fillAmount * 100).ToString("F1")+ "%";
    }
    public void DecreaseHp()
    {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.2f;
    }

    public void StopGame()
    {
        if (this.hpGauge.GetComponent<Image>().fillAmount <= 0f)
        {
            Time.timeScale = 0; // ¸ØÃç!
            restartButton.SetActive(true);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
        this.hpGauge.GetComponent<Image>().fillAmount = 1;
    }
}

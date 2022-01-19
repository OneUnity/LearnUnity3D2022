using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameRestarter : MonoBehaviour
{
    public GameObject hpGauge;
    public GameObject restartButton;
    public GameObject ArrowGenerator;
    // Start is called before the first frame update
    void Start()
    {
        this.restartButton = GameObject.Find("RestartButton");
        this.hpGauge = GameObject.Find("hpGauge");
        this.ArrowGenerator = GameObject.Find("ArrowGenerator");
        restartButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(this.hpGauge.GetComponent<Image>().fillAmount<=0f)
        {
            Time.timeScale = 0; // ¸ØÃç!
            restartButton.SetActive(true);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}

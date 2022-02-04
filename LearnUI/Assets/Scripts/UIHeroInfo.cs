using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHeroInfo : MonoBehaviour
{
    public Text userNameText;
    public Text levelValue;
    public Text attackValue;
    public Text defenseValue;
    public Text healthValue;
    public Text goldValue;
    public Text gemValue;

    public void Init(string userName, int level, float attack, float defense, float health, int gold, int gem)
    {
        this.userNameText.text = userName.ToString();
        this.levelValue.text = level.ToString();
        this.attackValue.text = attack.ToString();
        this.defenseValue.text = defense.ToString();
        this.healthValue.text = health.ToString();
        this.goldValue.text = gold.ToString();
        this.gemValue.text = gem.ToString();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

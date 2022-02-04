using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpController : MonoBehaviour
{
    public Slider HP_guage;
    public Button HPincreaseButton;
    void Start()
    {
        this.HPincreaseButton.onClick.AddListener(() => { HP_guage.value += 0.01f; });
    }
    public void HPincrease()
    {
        HP_guage.value += 0.01f;
    }
}
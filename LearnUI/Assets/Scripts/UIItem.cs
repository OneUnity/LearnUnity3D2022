using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIItem : MonoBehaviour
{
    public Image icon;

    public void Init(Sprite sp)
    {
        if (sp == null)
        {
            this.icon.gameObject.SetActive(false);
        }
        else
        {
            icon.sprite = sp;
            icon.SetNativeSize(); // 찌그러지지 않게
            this.icon.gameObject.SetActive(true);
        }
    }
}

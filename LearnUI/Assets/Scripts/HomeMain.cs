using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeMain : MonoBehaviour
{
    public UIHome uiHome;
    public UILoginPopup uiLoginPopup;

    // Start is called before the first frame update
    void Start()
    {
        this.uiLoginPopup.CloseButton.onClick.AddListener(() =>
        {
            this.uiLoginPopup.Close();
        });
        this.uiHome.btnSquare.onClick.AddListener(() =>
        {
            this.uiLoginPopup.Open();
        });
        this.uiLoginPopup.Close();
    }
}
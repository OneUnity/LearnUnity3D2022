using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UILoginPopup : MonoBehaviour
{
    public Button SignUpButton;
    public Button ForgotButton;
    public Button CloseButton;
    public GameObject UILoginPopUp;
    void Start()
    {
        this.SignUpButton.onClick.AddListener(() => { Debug.Log("Sign up"); });
        this.ForgotButton.onClick.AddListener(() => { Debug.Log("Forgot Password?"); });
        this.CloseButton.onClick.AddListener(() => { Debug.Log("Close"); });
        this.UILoginPopUp = GameObject.Find("UILoginPopUp");
    }

    void Update()
    {
        
    }
    /* public void GotoHome()
    {
        UILoginPopUp.SetActive(false);
    } */

    public void Open()
    {
        this.gameObject.SetActive(true);
    }

    public void Close()
    {
        this.gameObject.SetActive(false);
    }
}

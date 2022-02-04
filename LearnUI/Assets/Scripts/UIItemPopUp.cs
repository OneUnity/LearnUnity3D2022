using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIItemPopUp : MonoBehaviour
{
    public GameObject UILoginPopUp;
    public Button bgbutton;
    // Start is called before the first frame update
    void Start()
    {
        this.UILoginPopUp = GameObject.Find("UILoginPopUp");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GotoLogin()
    {
        Debug.Log("click");
        UILoginPopUp.SetActive(true);
    }
}

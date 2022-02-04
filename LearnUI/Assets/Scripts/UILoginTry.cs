using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UILoginTry : MonoBehaviour
{
    public InputField Email;
    public InputField Password;
    public Button btnLogin;
    // Start is called before the first frame update
    void Start()
    {
        this.btnLogin.onClick.AddListener(() =>
        {
            if(Email.text==string.Empty && Password.text!=string.Empty)
            {
                Debug.Log("아이디를 입력하세요.");
            }
            if(Password.text==string.Empty && Email.text!=string.Empty)
            {
                Debug.Log("비밀번호를 입력하세요.");
            }
            if(Email.text==string.Empty && Password.text==string.Empty)
            {
                Debug.Log("아이디와 비밀번호를 입력하세요.");
            }
            else if(Email.text != string.Empty && Password.text != string.Empty)
            {
                Debug.Log(Email.text);
                Debug.Log(Password.text);
            }
        });
    }
    void Update()
    {
        
    }
}

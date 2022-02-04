using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHome : MonoBehaviour
{
    public Button btnSquare;
    public Button btnCircle;
    public Button btnSquareforItem;
    public Button btnSquareforShop;
    public Button btnSquareforMessage;
    public Button btnSquareforMission;
    public Button btnSquareforRanking;
    public Button btnSquareforSetting;
    public Button btnSquareforHeartPlus; // heartplus만 연결하여 +를 눌렀을 때 반응하도록 설정할 예정.
    public Button btnSquareforGoldPlus;
    public Button btnSquareforGemPlus;
    public Button btnSquareforAddFriend;
    public Slider HPSlider;
    public Slider ExpSlider;
    public GameObject UILoginPopUp;
    void Start()
    {
        this.btnSquare.onClick.AddListener(() => { Debug.Log("Click"); });
        this.btnCircle.onClick.AddListener(() => { Debug.Log("Facebook"); });
        this.btnSquareforItem.onClick.AddListener(()=>{ Debug.Log("Items"); });
        this.btnSquareforShop.onClick.AddListener(() => { Debug.Log("Shop"); });
        this.btnSquareforMessage.onClick.AddListener(() => { Debug.Log("Messages"); });
        this.btnSquareforMission.onClick.AddListener(() => { Debug.Log("Mission"); });
        this.btnSquareforRanking.onClick.AddListener(() => { Debug.Log("Ranking"); });
        this.btnSquareforSetting.onClick.AddListener(() => { Debug.Log("Settings"); });
        this.btnSquareforHeartPlus.onClick.AddListener(() => { Debug.Log("HeartPlus"); });
        this.btnSquareforGoldPlus.onClick.AddListener(() => { Debug.Log("GoldPlus"); });
        this.btnSquareforGemPlus.onClick.AddListener(() => { Debug.Log("GemPlus"); });
        this.btnSquareforAddFriend.onClick.AddListener(() => { Debug.Log("AddFriends"); });
        this.UILoginPopUp = GameObject.Find("UILoginPopUp");
    }

    /* public void GotoLogin()
    {
        UILoginPopUp.SetActive(true);
    } */
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.U2D;

public class AtlasTest : MonoBehaviour
{
    public Image image;
    public SpriteAtlas atlas;
    // Start is called before the first frame update
    void Start()
    {
        Sprite sprite = atlas.GetSprite("Icon_ItemIcon_Sword_A");
        image.sprite = sprite; // �� sprite�� �ǹ̴� �ٸ���. �������� ������.
        image.SetNativeSize();

        // var width = image.rectTransform.sizeDelta.x *= 0.5f;
        // var height = image.rectTransform.sizeDelta.y *= 0.5f;
        // image.rectTransform.sizeDelta=new Vector2(width, height);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

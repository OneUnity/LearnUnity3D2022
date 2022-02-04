using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class UIInventory : MonoBehaviour
{
    public UIItem[] uiItems;
    public SpriteAtlas atlas;
    public void Init(ItemInfo[] itemInfos, Dictionary<int, ItemData> dic)
    {
        for(int i=0; i<uiItems.Length; i++) //uiItems.Length=6, itemInfos.Length=3
        {
            UIItem uiItem = uiItems[i];

            if(i>itemInfos.Length-1)
            {
                uiItem.Init(null);
            }
            else
            {
                ItemInfo uiItemInfo = itemInfos[i];
                ItemData itemData = dic[uiItemInfo.id];
                //display
                Sprite sp = atlas.GetSprite(itemData.spritename);
                uiItem.Init(sp);
            }
        }
    }
}
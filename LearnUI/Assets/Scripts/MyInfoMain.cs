using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Newtonsoft.Json;

public class MyInfoMain : MonoBehaviour
{
    public UIHeroInfo uiheroinfo;
    public UIInventory uiInventory;
    // Start is called before the first frame update
    void Start()
    {
        //item_data.json 데이터 로드
        var textAsset = Resources.Load<TextAsset>("item_data");
        var itemDataJson = textAsset.text;
        //역직렬화 수행
        ItemData[] itemDatas = JsonConvert.DeserializeObject<ItemData[]>(itemDataJson);
        Dictionary<int, ItemData> dicItemDatas = new Dictionary<int, ItemData>();
        foreach (var itemData in itemDatas)
        {
            dicItemDatas.Add(itemData.id, itemData);
        }
        print("아이템 개수: " + dicItemDatas.Count);


        Debug.Log(Application.persistentDataPath); // 1. 경로 확인
        var json = File.ReadAllText(Application.persistentDataPath + "/hero_info.json"); // 2. 불러들이기
        print(json);

        // 역직렬화(string->object(HeroInfo객체))
        HeroInfo heroInfo = JsonConvert.DeserializeObject<HeroInfo>(json);
        print(heroInfo.attack);

        this.uiheroinfo.Init(heroInfo.userName, heroInfo.level, heroInfo.attack, heroInfo.defense, heroInfo.health, heroInfo.gold, heroInfo.gem);
        /*
        // 아이템을 획득한다면...
        var itemInfo0 = this.GetItem(100);
        var itemInfo1 = this.GetItem(101);
        var itemInfo2 = this.GetItem(102);

        // 배열에 넣는다.
        List<ItemInfo> list = new List<ItemInfo>();
        list.Add(itemInfo0);
        list.Add(itemInfo1);
        list.Add(itemInfo2);

        //직렬화 (object->json)
        var itemsJson = JsonConvert.SerializeObject(list);
        Debug.Log(itemsJson); // [{"id: 100"}, {"id: 101"}, {"id: 102}] */
        var path = (Application.persistentDataPath + "/items_info.json");
        // File.WriteAllText(path, itemsJson);
        var itemsJson = File.ReadAllText(path); // 읽어들인다. (배열로 되어있음.)
        var itemInfos = JsonConvert.DeserializeObject<ItemInfo[]>(itemsJson); // 역직렬화
        this.uiInventory.Init(itemInfos, dicItemDatas);
    }

    public ItemInfo GetItem(int id)
    {
        return new ItemInfo(id);
    }
}

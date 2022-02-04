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
        //item_data.json ������ �ε�
        var textAsset = Resources.Load<TextAsset>("item_data");
        var itemDataJson = textAsset.text;
        //������ȭ ����
        ItemData[] itemDatas = JsonConvert.DeserializeObject<ItemData[]>(itemDataJson);
        Dictionary<int, ItemData> dicItemDatas = new Dictionary<int, ItemData>();
        foreach (var itemData in itemDatas)
        {
            dicItemDatas.Add(itemData.id, itemData);
        }
        print("������ ����: " + dicItemDatas.Count);


        Debug.Log(Application.persistentDataPath); // 1. ��� Ȯ��
        var json = File.ReadAllText(Application.persistentDataPath + "/hero_info.json"); // 2. �ҷ����̱�
        print(json);

        // ������ȭ(string->object(HeroInfo��ü))
        HeroInfo heroInfo = JsonConvert.DeserializeObject<HeroInfo>(json);
        print(heroInfo.attack);

        this.uiheroinfo.Init(heroInfo.userName, heroInfo.level, heroInfo.attack, heroInfo.defense, heroInfo.health, heroInfo.gold, heroInfo.gem);
        /*
        // �������� ȹ���Ѵٸ�...
        var itemInfo0 = this.GetItem(100);
        var itemInfo1 = this.GetItem(101);
        var itemInfo2 = this.GetItem(102);

        // �迭�� �ִ´�.
        List<ItemInfo> list = new List<ItemInfo>();
        list.Add(itemInfo0);
        list.Add(itemInfo1);
        list.Add(itemInfo2);

        //����ȭ (object->json)
        var itemsJson = JsonConvert.SerializeObject(list);
        Debug.Log(itemsJson); // [{"id: 100"}, {"id: 101"}, {"id: 102}] */
        var path = (Application.persistentDataPath + "/items_info.json");
        // File.WriteAllText(path, itemsJson);
        var itemsJson = File.ReadAllText(path); // �о���δ�. (�迭�� �Ǿ�����.)
        var itemInfos = JsonConvert.DeserializeObject<ItemInfo[]>(itemsJson); // ������ȭ
        this.uiInventory.Init(itemInfos, dicItemDatas);
    }

    public ItemInfo GetItem(int id)
    {
        return new ItemInfo(id);
    }
}

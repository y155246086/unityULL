using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UILoopListEzample : MonoBehaviour {

    public UILoopList uiList;
	// Use this for initialization
	void Start () {
        uiList.onSelectedEvent = OnSelectedEventHandler;
        List<int> listData = new List<int>();
        for (int i = 0; i < 1000; i++)
        {
            listData.Add(i);
        }
        uiList.Data(listData);
	}

    private void OnSelectedEventHandler(UILoopItem item)
    {
        Debug.LogError("选择的单元数据为:" + item.GetData().ToString());
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}

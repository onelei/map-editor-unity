using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using System.Collections.Generic;


public class MeDesigner:MonoBehaviour
{
    private int MaxX = 28;
    private int MaxY = 28;

    private string mBtnPath = "Button";
    private string mParentPath = "Canvas";
    private string mBtnItemPath = "Canvas/Button";
    List<GameObject> buttonList;
    private GameObject mParent;
    private GameObject mBtn;

    public MeDesigner()
    {
        buttonList = new List<GameObject>();
    }

    void Awake()
    {
        mParent = GameObject.Find(mParentPath);
        mBtn = transform.Find(mBtnItemPath).gameObject;

    }

    [ContextMenu("Start")]
    void Start()
    {
        for (int x = 0; x < MaxX; ++x)
        {
            for (int y = 0; y < MaxY; ++y)
            {
                GameObject btn = Instantiate(mBtn) as GameObject;
                btn.transform.parent =  mParent.transform;
                string text = "(" + x + "," + y + ")";
                btn.name = text;
                setSize(btn, 100, 100);
                setName(btn, text);
                buttonList.Add(btn);
            }

        }
        mBtn.SetActive(false);
        mParent.GetComponent<UIGrid>().Reposition();
    }

    void onClick(GameObject obj)
    {
        Debug.Log("11");
    }

    void setName(GameObject obj,string name)
    {
        UIButton btn = obj.GetComponent<UIButton>();
        UILabel text = btn.transform.Find("Label").GetComponent<UILabel>();
        text.text = name;
    }

    void setSize(GameObject obj , int x,int y)
    {
        UISprite sp = obj.GetComponent<UISprite>();
        sp.width = x;
        sp.height = y;
    }
 }


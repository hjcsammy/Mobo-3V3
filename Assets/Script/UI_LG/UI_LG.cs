using UnityEngine;
using System.Collections;

public class UI_LG : GUIBase
{

    public GameObject UI_FightTouch;

    public GameObject UI_Setting;

    public bool isFT = true;

    public bool isSet = false;

    public GUISingleButton switchBtn;

    public GUISingleButton KGFmapBtn;

    public bool isMap = false;

    private GameObject itsKGFMapSystem;

    public override UIPanleID GetUIKey()
    {
        return UIPanleID.none;
    }

    void Start()
    {
        UI_FightTouch = transform.parent.Find("FightTouch").gameObject;
        UI_Setting = transform.parent.Find("UISetting").gameObject;

        itsKGFMapSystem = GameObject.Find("KGFMapSystem").gameObject;

        switchBtn = transform.Find("switchBtn").gameObject.transform.GetComponent<GUISingleButton>();
        KGFmapBtn = transform.Find("KGFmapBtn").gameObject.transform.GetComponent<GUISingleButton>();

        switchBtn.onClick= OnSwitchBtnClick;
        KGFmapBtn.onClick = OnKGFmapBtnClick;
    }


    public void OnSwitchBtnClick()
    {
        UI_Setting.SetActive(isFT);
        UI_FightTouch.SetActive(isSet);
        isFT = !isFT;
        isSet = !isSet;
       
    }

    public void OnKGFmapBtnClick()
    {
        //KGFMapSystem sys = new KGFMapSystem();
        //sys.SetMinimapEnabled(isMap);
        //KGFMapSystem.KGFDataMinimap map = new KGFMapSystem.KGFDataMinimap();
        //map.itsIsActive = isMap;
        //itsKGFMapSystem.SetMinimapEnabled(false);
        itsKGFMapSystem.SetActive(isMap);
        isMap = !isMap;
    }
}

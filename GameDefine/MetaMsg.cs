using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UICommon;

namespace GameDefine
{
    public enum META_MSG
    {
        NO_LOCK_TARGET = 100,
    }

    public static class MetaMsg
    {
        public static string Meta_String(META_MSG msg)
        {
            string meta = "";
            switch (msg)
            {
                case META_MSG.NO_LOCK_TARGET:
                    meta = "没有锁定目标";
                    break;
            }
            return meta;
        }

        public static void ShowBoxTips(string currInfo, float timeVis, float duration)
        {
            GameObject obj = GameMethod.CreateWindow(GameConstDefine.MessageTipUI, new Vector3(0, -1, 0), GameMethod.GetUiCamera.transform);
            UIMessageTip uims = obj.GetComponent<UIMessageTip>();
            uims.SetCapionInfo(currInfo, timeVis);
            UICommonMethod.TweenPositionBegin(obj, duration, Vector3.zero, UITweener.Style.Once);
        }
    }
}

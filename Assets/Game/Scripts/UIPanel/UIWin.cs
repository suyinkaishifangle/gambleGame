using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class UIWin : UIBase
{
   

    public override void DoOnEntering()
    {
        transform.DOLocalMoveY(0, 1f);
    }

    public override void DoOnPausing()
    {
        CanvasGroup.alpha = 0f;
    }

    public override void DoOnResuming()
    {
        CanvasGroup.alpha = 1f;
    }

    public override void DoOnExiting()
    {
        CanvasGroup.alpha = 0f;
    }

    public void OnRePlayClick()
    {
        UIManager.Instance.PopUIPanel();
    }
}

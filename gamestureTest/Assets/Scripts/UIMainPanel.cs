using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMainPanel : MonoBehaviour
{
    public void PopupButtonPressed()
    {
        MainPanelController.Instance.PopupCanvasSetActive(true);
    }

    public void TextButtonPressed()
    {
        MainPanelController.Instance.TextCanvasSetActive();
    }

    public void SoundButtonPressed()
    {
        SoundManager.Instance.PlaySound();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainPanelController : MonoBehaviour
{
    #region SINGLETON
    private static MainPanelController instance = null;
    public static MainPanelController Instance
    {
        get
        {
            if (instance == null)
            {
                instance = (MainPanelController)FindObjectOfType(typeof(MainPanelController));
            }
            return instance;
        }
    }
    #endregion

    [SerializeField] private GameObject popupCanvas = null;
    [SerializeField] private GameObject textCanvas = null;
    [SerializeField] private Text soundButtonText = null;
    private Coroutine textCanvasCoroutineHandler = null;

    public void PopupCanvasSetActive(bool value)
    {
        popupCanvas.SetActive(value);
    }

    public void TextCanvasSetActive()
    {
        if (textCanvasCoroutineHandler != null)
            StopCoroutine(textCanvasCoroutineHandler);

        textCanvasCoroutineHandler = StartCoroutine(ShowTextCanvasCoroutine());
    }

    public void ChangeSoundButtonText(bool value)
    {
        soundButtonText.text = value == false ? "TURN OFF" : "SOUND";
    }

    private IEnumerator ShowTextCanvasCoroutine()
    {
        textCanvas.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        textCanvas.SetActive(false);
    }
}

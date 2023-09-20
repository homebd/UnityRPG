using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private static UIManager _instance;
    public static UIManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<UIManager>();
                if (_instance == null)
                {
                    GameObject obj = new GameObject("UIManager");
                    _instance = obj.AddComponent<UIManager>();
                }
            }
            return _instance;
        }
    }

    public List<Canvas> Canvases;
    private Canvas _curCanvas;

    public void TogglePanel(PanelType type) {
        if(_curCanvas == null){
            _curCanvas = Canvases[(int)type];
            _curCanvas.gameObject.SetActive(true);
        }
        else {
            if(_curCanvas.gameObject.activeSelf)
                _curCanvas.gameObject.SetActive(false);

            if(_curCanvas == Canvases[(int)type]) {
                _curCanvas = null;
            }
            else {
                _curCanvas = Canvases[(int)type];
                _curCanvas.gameObject.SetActive(true);
            }
        }
    }
}

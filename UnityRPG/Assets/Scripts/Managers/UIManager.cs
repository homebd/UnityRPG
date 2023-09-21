using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // 굳이 싱글톤이어야 하나?
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
    public List<Button> Buttons;
    private Canvas _curCanvas;

    private void Awake() {
        for(int i = 0; i < Buttons.Count; i++) {
            Button btn = Buttons[i];

            // 람다는 그냥 넣으면 마지막 값을 캡쳐함
            int index = i;
            btn.onClick.AddListener(() => TogglePanel(index));
        }
    }

    public void LateStart() {
        foreach(var canvas in Canvases) {
            canvas.gameObject.SetActive(false);
        }
    }

    public void TogglePanel(int type) {
        if(_curCanvas == null) {
            _curCanvas = Canvases[type];
            _curCanvas.gameObject.SetActive(true);
        }
        else {
            if(_curCanvas.gameObject.activeSelf)
                _curCanvas.gameObject.SetActive(false);

            if(_curCanvas == Canvases[type]) {
                _curCanvas = null;
            }
            else {
                _curCanvas = Canvases[type];
                _curCanvas.gameObject.SetActive(true);
            }
        }
    }
}

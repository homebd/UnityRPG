using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionButton : MonoBehaviour
{
    public PanelType Type;

    public void NotifyPanelActivation() {
        UIManager.Instance.TogglePanel(Type);
    }
}

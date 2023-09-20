using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusUI : MonoBehaviour
{
    public CharacterStatController StatController;  
    public Text NameText;
    public Text LevelText;
    public Text ExpText;
    public Slider ExpSlider;
    public Text AtkText;
    public Text DefText;
    public Text CCText;
    public Text CDText;
    public Text DCText;

    private void Awake() {
        StatController.OnChangeStatEvent += UpdateStatus;
    }

    public void UpdateStatus(CharacterStatsHandler stat) {
        NameText.text = stat.CurStats.Name;
        LevelText.text = stat.CurStats.Level.ToString();
        ExpText.text = $"{stat.CurStats.Exp} / {stat.CurStats.Level}";
        ExpSlider.value = (float) stat.CurStats.Exp / stat.CurStats.Level;
        AtkText.text = stat.CurStats.Atk.ToString();
        DefText.text = stat.CurStats.Def.ToString();
        CCText.text = stat.CurStats.CC.ToString("N1");
        CDText.text = stat.CurStats.CD.ToString("N1");
        DCText.text = stat.CurStats.DC.ToString("N1");
    }
}

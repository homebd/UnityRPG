using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatsData : CharacterStatsData
{
    public PlayerType Type;

    public void LevelUp() {
        Level++;
        if(Level % 2 == 0) Atk++;
        Def++;
        CC += 0.1f;
        DC += 0.1f;
    }
}

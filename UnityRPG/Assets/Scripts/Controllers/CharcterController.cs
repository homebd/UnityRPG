using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharcterController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;

    protected CharacterStatsHandler Stats;
}

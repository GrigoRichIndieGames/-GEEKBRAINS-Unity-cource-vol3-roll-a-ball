﻿using UnityEngine;


namespace GrigorichIndieGames_CosmoLoader
{
    [CreateAssetMenu(fileName = "BuffController", menuName = "Data/dataBuff")]
    internal sealed class BuffData : ScriptableObject
    {
        public float EffectModificator;
        public float TimeOfAction;
    }
}

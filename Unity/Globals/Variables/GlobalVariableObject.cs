﻿namespace Morpeh.Globals {
    using UnityEngine;
    using Unity.IL2CPP.CompilerServices;

    [Il2CppSetOption(Option.NullChecks, false)]
    [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
    [Il2CppSetOption(Option.DivideByZeroChecks, false)]
    [CreateAssetMenu(menuName = "ECS/Globals/Variable Object")]
    public class GlobalVariableObject : BaseGlobalVariable<Object> {
        public override bool CanBeSerialized => false;

        protected override Object Load(string serializedData) => null;

        protected override string Save() => string.Empty;
    }
}
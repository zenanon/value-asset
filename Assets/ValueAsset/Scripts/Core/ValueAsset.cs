using System;
using UnityEngine;

namespace ValueAsset.Core {
    public abstract class ValueAsset<T, TV> : ScriptableObject where TV : ValueAsset<T, TV> {

        public delegate void OnValueChangedDelegate (T value);

        public event OnValueChangedDelegate OnValueChanged = delegate { };

        [SerializeField] protected T defaultValue = default;

        [NonSerialized] private bool overridden = false;
        [NonSerialized] private T runtimeValue = default;

        public T Value {
            get => overridden ? runtimeValue : defaultValue;
            set {
                overridden = true;
                runtimeValue = value;
                OnValueChanged(runtimeValue);
            }
        }

        public void ResetToDefault () {
            Value = defaultValue;
        }

        public TV CopyWithDefault () {
            return CreateValueAsset(defaultValue);
        }

        public static TV CreateValueAsset (T defaultValue) {
            TV valueAsset = CreateInstance<TV>();

            valueAsset.defaultValue = defaultValue;

            return valueAsset;
        }
    }
}
using UnityEngine;
using UnityEngine.UI;
using ValueAsset.Core;

namespace ValueAsset.UI.TextDisplay {
    /// <summary>
    /// Abstract base for updating a text field based on the value of a ValueAsset.
    /// </summary>
    public abstract class ValueTextDisplay<T, TV> : MonoBehaviour where TV : ValueAsset<T, TV> {
        [SerializeField] private Text text = default;
        [SerializeField] private string formatString = "{0}";
        [SerializeField] private TV valueAsset = default;

        private void Awake () {
            valueAsset.OnValueChanged += UpdateText;
            UpdateText(valueAsset.Value);
        }

        private void UpdateText (T value) {
            text.text = string.Format(string.IsNullOrWhiteSpace(formatString) ? "{0}" : formatString, value);
        }
    }
}
using UnityEngine;
using UnityEngine.UI;
using ValueAsset.Core;

namespace ValueAsset.UI.TextDisplay {
    public class StringAssetTextEntry : MonoBehaviour {
        [SerializeField] private StringAsset stringAsset = null;
        [SerializeField] private InputField inputField = null;

        private void Awake () {
            stringAsset.OnValueChanged += OnStringValueUpdated;
            OnStringValueUpdated(stringAsset.Value);
            inputField.onEndEdit.AddListener(UpdateStringAsset);
        }

        private void OnStringValueUpdated (string value) {
            inputField.text = value;
        }

        private void UpdateStringAsset (string value) {
            stringAsset.Value = value;
        }
    }
}
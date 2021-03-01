using UnityEditor;
using UnityEngine;

namespace ValueAsset.Core.Editor {
    public abstract class ValueAssetEditor<T, TV> : UnityEditor.Editor where TV : ValueAsset<T, TV> {
        public override void OnInspectorGUI () {
            DrawDefaultInspector();
            
            TV valueAsset = target as TV;

            bool wasEnabled = GUI.enabled;
            GUI.enabled = Application.isPlaying;
            EditorGUI.BeginChangeCheck();
            T value = EditorField("Runtime Value", valueAsset.Value);
            if (EditorGUI.EndChangeCheck()) {
                valueAsset.Value = value;
            }

            if (GUILayout.Button("Reset To Default")) {
                valueAsset.ResetToDefault();
            }

            GUI.enabled = wasEnabled;
        }

        protected abstract T EditorField (string fieldName, T current);
    }
}
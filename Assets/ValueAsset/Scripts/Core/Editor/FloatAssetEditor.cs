using UnityEditor;

namespace ValueAsset.Core.Editor {
    [CustomEditor(typeof(FloatAsset))]
    public class FloatAssetEditor : ValueAssetEditor<float, FloatAsset> {
        protected override float EditorField (string fieldName, float current) {
            return EditorGUILayout.FloatField(fieldName, current);
        }
    }
}
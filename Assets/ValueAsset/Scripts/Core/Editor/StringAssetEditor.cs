using UnityEditor;

namespace ValueAsset.Core.Editor {
    [CustomEditor(typeof(StringAsset))]
    public class StringAssetEditor : ValueAssetEditor<string, StringAsset> {
        protected override string EditorField (string fieldName, string current) {
            return EditorGUILayout.TextField(fieldName, current);
        }
    }
}
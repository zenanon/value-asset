using UnityEditor;

namespace ValueAsset.Core.Editor {
    [CustomEditor(typeof(BoolAsset))]
    public class BoolAssetEditor : ValueAssetEditor<bool, BoolAsset> {
        protected override bool EditorField (string fieldName, bool current) {
            return EditorGUILayout.Toggle(fieldName, current);
        }
    }
}
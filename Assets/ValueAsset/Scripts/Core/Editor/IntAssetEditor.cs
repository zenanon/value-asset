using UnityEditor;

namespace ValueAsset.Core.Editor {
    [CustomEditor(typeof(IntAsset))]
    public class IntAssetEditor : ValueAssetEditor<int, IntAsset> {

        protected override int EditorField (string fieldName, int current) {
            return EditorGUILayout.IntField(fieldName, current);
        }
    }
}
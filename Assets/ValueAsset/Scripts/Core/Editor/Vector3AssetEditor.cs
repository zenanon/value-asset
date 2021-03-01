using UnityEditor;
using UnityEngine;

namespace ValueAsset.Core.Editor {
    [CustomEditor(typeof(Vector3Asset))]
    public class Vector3AssetEditor : ValueAssetEditor<Vector3, Vector3Asset> {
        protected override Vector3 EditorField (string fieldName, Vector3 current) {
            return EditorGUILayout.Vector3Field(fieldName, current);
        }
    }
}
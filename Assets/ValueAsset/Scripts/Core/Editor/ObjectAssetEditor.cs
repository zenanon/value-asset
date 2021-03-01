using UnityEditor;
using UnityEngine;

namespace ValueAsset.Core.Editor {
    public abstract class ObjectAssetEditor<T, TV> : ValueAssetEditor<T, TV> where TV : ValueAsset<T, TV> where T : Object {
        protected override T EditorField (string fieldName, T current) {
            return EditorGUILayout.ObjectField(fieldName, current, typeof(T), target) as T;
        }
    }
}
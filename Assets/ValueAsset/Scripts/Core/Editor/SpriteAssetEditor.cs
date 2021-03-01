using UnityEditor;
using UnityEngine;

namespace ValueAsset.Core.Editor {
    [CustomEditor(typeof(SpriteAsset))]
    public class SpriteAssetEditor : ObjectAssetEditor<Sprite, SpriteAsset> { }
}
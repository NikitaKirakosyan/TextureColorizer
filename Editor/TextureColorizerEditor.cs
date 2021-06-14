/*
 * author : Kirakosyan Nikita
 * e-mail : nikita.kirakosyan.work@gmail.com
 */
using UnityEngine;
using UnityEditor;

namespace NikitaKirakosyan.Utils
{
    [CustomEditor(typeof(TextureColorizer))]
    public class TextureColorizerEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            if (GUILayout.Button("Decolor"))
            {
                var decolorizer = (TextureColorizer)target;
                decolorizer.targetTexture = TextureColorizer.GetRecoloredTexture(decolorizer.targetTexture, decolorizer.targetColor);
            }
        }
    }
}
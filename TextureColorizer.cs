/*
 * author : Kirakosyan Nikita
 * e-mail : nikita.kirakosyan.work@gmail.com
 */
using UnityEngine;

namespace NikitaKirakosyan.Utils
{
    /// <summary>
    /// Заливает цветом текстуру.
    /// </summary>
    [CreateAssetMenu(fileName = "Texture Colorizer", menuName = "Create Texture Colorizer", order = 1)]
    public class TextureColorizer : ScriptableObject
    {
        public Texture2D targetTexture = null;
        public Color targetColor = Color.white;

        #region Public Methods
        /// <summary>
        /// Возвращает текстуру, залитую цветом.
        /// </summary>
        /// <param name="texture">Texture to decolor.</param>
        public static Texture2D GetRecoloredTexture(Texture2D texture, Color color)
        {
            if (texture == null)
            {
                Debug.LogError("No target texture set!");
                return null;
            }

            for (int y = 0; y < texture.height; y++)
            {
                for (int x = 0; x < texture.width; x++)
                {
                    if (texture.GetPixel(x, y).a != 0)
                    {
                        texture.SetPixel(x, y, color);
                    }
                    else
                    {
                        texture.SetPixel(x, y, Color.clear);
                    }
                }
            }
            texture.alphaIsTransparency = true;
            texture.Apply();

            return texture;
        }
        #endregion
    }
}
using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;


#if UNITY_EDITOR
using UnityEditor;
public class ImageModifier : MonoBehaviour
{
    [Button]
    void ChangeImageResolution(Texture2D texture)
    {
        int width = texture.width;
        int height = texture.height;
        //get the closes number divisible by 4
        width = width - width % 4;
        height = height - height % 4;
        texture.Resize(width, height);

        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
    }
}

#endif

using UnityEngine;
using UnityEditor;

namespace Assets.Example.Editor
{
    public class EditorSC
    {
        [MenuItem("Tools/Show MessageEx")]
        public static void ShowMessageEx()
        {
            Debug.Log("This is an editor's script");
        }
    }
}

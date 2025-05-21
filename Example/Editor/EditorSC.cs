using UnityEngine;
using UnityEditor;

namespace Assets.Example.Editor
{
    public class EditorSC
    {
        [MenuItem("Tools/Show Message")]
        public static void ShowMessage()
        {
            Debug.Log("This is an editor's script");
        }
    }
}

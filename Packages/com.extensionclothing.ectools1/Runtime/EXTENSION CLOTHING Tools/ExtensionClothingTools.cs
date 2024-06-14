using UnityEngine;
using UnityEditor;

public class ExtensionClothingTools : EditorWindow
{
    // ウィンドウを表示するためのメニュー項目を追加
    [MenuItem("EXTENSION CLOTHING/ECTool_1")]
    public static void ShowECTool1Window()
    {
        // ウィンドウを作成して表示
        GetWindow<ECTool_1>("ECTool_1 Window");
    }

    // 他のツールウィンドウも同様に追加可能
    // [MenuItem("EXTENSION CLOTHING/AnotherTool")]
    // public static void ShowAnotherToolWindow()
    // {
    //     GetWindow<AnotherTool>("Another Tool Window");
    // }
}

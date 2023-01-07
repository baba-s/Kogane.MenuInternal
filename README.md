# Kogane Menu Internal

Menu クラスの internal な機能にアクセスできる機能

## 使用例

```cs
using Kogane;
using UnityEditor;
using UnityEngine;

[InitializeOnLoad]
public static class Example
{
    static Example()
    {
        // ホットキーの設定
        MenuInternal.SetHotkey( "File/Exit", "%q" );

        // サブメニューをすべて取得
        foreach ( var submenu in MenuInternal.ExtractSubmenus( "File" ) )
        {
            Debug.Log( submenu );
        }

        // メニューの追加
        MenuInternal.AddMenuItem
        (
            name: "a/a",
            shortcut: "",
            @checked: false,
            priority: 0,
            execute: () => Debug.Log( "ピカチュウ" ),
            validate: null
        );

        // メニューの追加（簡易）
        MenuInternal.AddMenuItem
        (
            name: "a/b",
            execute: () => Debug.Log( "カイリュー" )
        );

        // メニューの削除
        MenuInternal.RemoveMenuItem( "Component" );

        // 区切り線の追加（動作未確認）
        //MenuInternal.AddSeparator( "a/", 2 );

        // すべてのメニューのリビルド（動作未確認）
        // MenuInternal.RebuildAllMenus();

        // メニューが存在する場合 true
        Debug.Log( MenuInternal.MenuItemExists( "GameObject" ) );
    }
}
```
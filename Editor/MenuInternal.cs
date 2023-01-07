using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEditor;

namespace Kogane
{
    public static class MenuInternal
    {
        private static readonly Type         TYPE         = typeof( Menu );
        private static readonly BindingFlags BINDING_ATTR = BindingFlags.Static | BindingFlags.NonPublic;

        public static void GetMenuItemDefaultShortcuts
        (
            List<string> outItemNames,
            List<string> outItemDefaultShortcuts
        )
        {
            var methodInfo = TYPE.GetMethod( "GetMenuItemDefaultShortcuts", BINDING_ATTR );
            methodInfo!.Invoke( null, new object[] { outItemNames, outItemDefaultShortcuts } );
        }

        public static void SetHotkey
        (
            string menuPath,
            string hotkey
        )
        {
            var methodInfo = TYPE.GetMethod( "SetHotkey", BINDING_ATTR );
            methodInfo!.Invoke( null, new object[] { menuPath, hotkey } );
        }

        public static string[] ExtractSubmenus( string menuPath )
        {
            var methodInfo = TYPE.GetMethod( "ExtractSubmenus", BINDING_ATTR );
            return ( string[] )methodInfo!.Invoke( null, new object[] { menuPath } );
        }

        public static void AddMenuItem( string name, Action execute )
        {
            AddMenuItem
            (
                name: name,
                shortcut: "",
                @checked: false,
                priority: 0,
                execute: execute,
                validate: null
            );
        }

        public static void AddMenuItem
        (
            string     name,
            string     shortcut,
            bool       @checked,
            int        priority,
            Action     execute,
            Func<bool> validate
        )
        {
            var methodInfo = TYPE.GetMethod( "AddMenuItem", BINDING_ATTR );
            methodInfo!.Invoke( null, new object[] { name, shortcut, @checked, priority, execute, validate } );
        }

        public static void RemoveMenuItem( string name )
        {
            var methodInfo = TYPE.GetMethod( "RemoveMenuItem", BINDING_ATTR );
            methodInfo!.Invoke( null, new object[] { name } );
        }

        public static void AddSeparator( string name, int priority )
        {
            var methodInfo = TYPE.GetMethod( "AddSeparator", BINDING_ATTR );
            methodInfo!.Invoke( null, new object[] { name, priority } );
        }

        public static void RebuildAllMenus()
        {
            var methodInfo = TYPE.GetMethod( "RebuildAllMenus", BINDING_ATTR );
            methodInfo!.Invoke( null, Array.Empty<object>() );
        }

        public static int FindHotkeyStartIndex( string menuPath )
        {
            var methodInfo = TYPE.GetMethod( "FindHotkeyStartIndex", BINDING_ATTR );
            return ( int )methodInfo!.Invoke( null, new object[] { menuPath } );
        }

        public static bool MenuItemExists( string menuPath )
        {
            var methodInfo = TYPE.GetMethod( "MenuItemExists", BINDING_ATTR );
            return ( bool )methodInfo!.Invoke( null, new object[] { menuPath } );
        }
    }
}
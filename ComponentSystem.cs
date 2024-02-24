using Godot;
using System;
using System.Runtime.CompilerServices;

namespace GH
{
    namespace ComponentSystem
    {
        public static class NodeExtensions
        {
            public static T GetComponent<T>(this Node node) where T : Node
            {
                return node.GetNodeOrNull<T>(typeof(T).Name);
            }

            public static T AddComponent<T>(this Node node, T component) where T : Node
            {
                component.Name = typeof(T).Name;
                node.AddChild(component);
                return component;
            }

        }
    }
}

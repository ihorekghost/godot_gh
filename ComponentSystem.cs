namespace GH
{
    namespace ComponentSystem
    {
        using Godot;


        public static class NodeExtensions
        {
            public static TComponent GetComponent<TComponent>(this Node node) where TComponent : Node
            {
                IComponentCacher<TComponent> cacher = node as IComponentCacher<TComponent>;
                if (cacher == null)
                {
                    return node.GetNodeOrNull<TComponent>(typeof(TComponent).Name);
                }

                return cacher.CachedComponent;
            }

            public static TComponent AddComponent<TComponent>(this Node node, TComponent component) where TComponent : Node
            {
                component.Name = typeof(TComponent).Name;
                node.AddChild(component);
                return component;
            }

        }
    }
}

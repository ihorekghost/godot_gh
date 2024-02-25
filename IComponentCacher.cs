namespace GH
{
    namespace ComponentSystem
    {
        public partial interface IComponentCacher<TComponent>
        {
            public TComponent CachedComponent { get; }
        }
    }
}
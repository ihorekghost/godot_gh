namespace GH
{
    namespace SceneManager
    {
        using Godot;

        [GlobalClass]
        public partial class SceneManager : Node
        {
            [Export]
            public Node CurrentScene { get; private set; } = null;

            public void QueueSwitchScene(PackedScene newScene)
            {
                CallDeferred(MethodName.SwitchScene, newScene.Instantiate());
            }

            public void QueueSwitchScene(Node newSceneNode)
            {
                CallDeferred(MethodName.SwitchScene, newSceneNode);
            }

            public void SwitchScene(Node newSceneNode)
            {

                if (newSceneNode != CurrentScene)
                {
                    if (CurrentScene != null)
                    {
                        RemoveChild(CurrentScene);
                        CurrentScene.Free();
                    }

                    CurrentScene = newSceneNode;

                    AddChild(newSceneNode);
                }
            }
        }

    }
}

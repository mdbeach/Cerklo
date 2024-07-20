using osu.Framework.Testing;

namespace Cerklo.Game.Tests.Visual
{
    public abstract partial class CerkloTestScene : TestScene
    {
        protected override ITestSceneTestRunner CreateRunner() => new CerkloTestSceneTestRunner();

        private partial class CerkloTestSceneTestRunner : CerkloGameBase, ITestSceneTestRunner
        {
            private TestSceneTestRunner.TestRunner runner;

            protected override void LoadAsyncComplete()
            {
                base.LoadAsyncComplete();
                Add(runner = new TestSceneTestRunner.TestRunner());
            }

            public void RunTestBlocking(TestScene test) => runner.RunTestBlocking(test);
        }
    }
}

using Microsoft.Practices.Unity;

namespace SurveyService.Common.Unity
{
    public interface IShell
    {
        void Start<T>() where T : UnityContainerExtension, new();

        void Start(UnityContainerExtension initialization = null);

        void Shutdown();

        void Restart();
    }
}

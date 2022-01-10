using CluedIn.Core;
using CluedIn.Core.Server;
using CluedIn.Processing.Events;
using ComponentHost;

namespace Jat.Common.Components
{
    public class CommonComponent
    {
        [Component("JatCommon", ComponentType.Service, "Server", Isolation = ComponentIsolation.NotIsolated)]
        public class JatCommonComponent : ServiceApplicationComponent<IServer>
        {
            public JatCommonComponent([NotNull] ComponentInfo componentInfo)
                : base(componentInfo)
            {
            }
            public override void Start()
            {
                //this.eventHandlers = new WorkflowEventHandlers(this.ApplicationContext);
                this.State = ServiceState.Started;
            }
            public override void Stop()
            {
                this.State = ServiceState.Stopped;
            }
        }
    }
}

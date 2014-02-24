using ImBusing.Domain.Services;
using Nancy.Bootstrapper;
using Nancy.Bootstrappers.Ninject;
using Nancy.Conventions;
using Ninject;
using Nancy;

namespace ImBusing
{
    public class Bootstrapper : NinjectNancyBootstrapper
    {

        protected override void ApplicationStartup(IKernel container, IPipelines pipelines)
        {
            // No registrations should be performed in here, however you may
            // resolve things that are needed during application startup.
        }

        protected override void ConfigureApplicationContainer(IKernel existingContainer)
        {
            // Perform registation that should have an application lifetime
            existingContainer.Bind<ICountDownService>().To<CountDownService>().InSingletonScope();
            base.ConfigureApplicationContainer(existingContainer);
            
        }

        protected override void ConfigureRequestContainer(IKernel container, NancyContext context)
        {
            // Perform registrations that should have a request lifetime

        }

        protected override void RequestStartup(IKernel container, IPipelines pipelines, NancyContext context)
        {
            // No registrations should be performed in here, however you may
            // resolve things that are needed during request startup.
        }

        protected override void ConfigureConventions(NancyConventions nancyConventions)
        {
            base.ConfigureConventions(nancyConventions);
            nancyConventions.StaticContentsConventions.Add(StaticContentConventionBuilder.AddDirectory("Scripts", "Scripts"));
        }


    }
}
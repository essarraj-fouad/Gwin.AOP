using Castle.Core;
using Castle.MicroKernel;
using Castle.MicroKernel.Registration;
using GApp.Security;
using System;

namespace GApp.AOP
{
    public class ComponentRegistration : IRegistration
    {
        public void Register(IKernelInternal kernel)
        {
            //kernel.Register(
            //    Component.For<SecurityInterceptor>()
            //        .ImplementedBy<SecurityInterceptor>());

           // kernel.Register(Component.For<SecurityAspect>());


            // Registrer All BLO Objects

            //foreach (Type EntityType in new GwinEntitiesManager().GetAll_Entities_Type())
            //{

            //    Type BLOEntity_Type = GwinBaseBLO<BaseEntity>.Detemine_Type_EntityBLO(EntityType, GwinApp.Instance.TypeBaseBLO);


            //    //   kernel.Register(
            //    //Component.For(BLOEntity_Type).ImplementedBy(BLOEntity_Type)
            //    //         .Interceptors(
            //    //    InterceptorReference.ForType<SecurityInterceptor>()).Anywhere);

            //    kernel.Register(
            //  Component.For(BLOEntity_Type).ImplementedBy(BLOEntity_Type)
            //  .Interceptors(
            //      typeof(SecurityAspect)
            //      ));

            //}

        }
    }
}

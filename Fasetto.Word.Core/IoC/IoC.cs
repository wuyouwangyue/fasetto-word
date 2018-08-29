using System;
using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;
using Ninject;

namespace Fasetto.Word.Core
{
    public static class IoC
    {
        #region Public Properties

        public static IKernel Kernel => new StandardKernel();


        #endregion

        #region Constructor

        public static void Setup()
        {
            BindViewModels();
        }

        private static void BindViewModels()
        {
            SimpleIoc.Default.Register<ApplicationViewModel>();
        }


        #endregion

        public static T Get<T>()
        {
            return ServiceLocator.Current.GetInstance<T>();
        }
    }
}

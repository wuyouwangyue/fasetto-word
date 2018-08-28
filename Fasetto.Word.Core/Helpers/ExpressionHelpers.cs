using System;
using System.Linq.Expressions;
using System.Reflection;

namespace Fasetto.Word.Core
{
    public static class ExpressionHelpers
    {
        public static T GetPropertyValue<T>(this Expression<Func<T>> lamba)
        {
            return lamba.Compile().Invoke();
        }

        public static void SetPropertyValue<T>(this Expression<Func<T>> lamba, T value)
        {
            var experssion = (lamba as LambdaExpression).Body as MemberExpression;

            var propertyInfo = (PropertyInfo)experssion.Member;
            var target = Expression.Lambda(experssion.Expression).Compile()?.DynamicInvoke();

            propertyInfo.SetValue(target, value);
        }
    }
}

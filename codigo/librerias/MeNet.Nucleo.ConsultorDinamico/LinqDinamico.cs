
using System;
using System.Collections;
using System.Collections.Generic;

using System.Text;

using System.Reflection;
using System.Reflection.Emit;
using System.Threading;

using System.Linq;
using System.Linq.Expressions;
//using System.Linq.Dynamic;

namespace MeNet.Nucleo.ConsultorDinamico
{
    public static  partial class LinqDinamico
    {
        public static IEnumerable Select(this IEnumerable source, string selector, params object[] values)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (selector == null) throw new ArgumentNullException("selector");
            if (!selector.Contains("new"))
                selector = "new (" + selector + " )";
            LambdaExpression lambda = System.Linq.Dynamic.DynamicExpression.ParseLambda(source.AsQueryable().ElementType, null, selector, values);
            return source.AsQueryable().Provider.CreateQuery(
                Expression.Call(
                typeof(Queryable), "Select",
                new Type[] { source.AsQueryable().ElementType, lambda.Body.Type },
                source.AsQueryable().Expression,
                Expression.Quote(lambda)));
        }

        public static IEnumerable<T> Select<T>(this IEnumerable source, string selector, Type tipo, params object[] values)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (selector == null) throw new ArgumentNullException("selector");
            if (!selector.Contains("new"))
                selector = "new (" + selector + " )";
            LambdaExpression lambda = System.Linq.Dynamic.DynamicExpression.ParseLambda(source.AsQueryable().ElementType, null, selector, values);
            return source.AsQueryable().Provider.CreateQuery(
                Expression.Call(
                typeof(Queryable), "Select",
                new Type[] { source.AsQueryable().ElementType, lambda.Body.Type },
                source.AsQueryable().Expression,
               Expression.Quote(lambda))).Cast<T>();

        }
        public static IEnumerable<T> Select<T>(this IEnumerable source, string selector, params object[] values)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (selector == null) throw new ArgumentNullException("selector");
            if (!selector.Contains("new"))
                selector = "new (" + selector + " )";
            Type tipo = source.AsQueryable().ElementType;
            LambdaExpression lambda = System.Linq.Dynamic.DynamicExpression.ParseLambda(source.AsQueryable().ElementType, null, selector, values);
            return source.AsQueryable().Provider.CreateQuery(
                Expression.Call(
                typeof(Queryable), "Select",
                new Type[] { source.AsQueryable().ElementType, lambda.Body.Type },
                source.AsQueryable().Expression,
                Expression.Quote(lambda))).Cast<T>();
        }
        public static IQueryable Select(this IQueryable source, string selector, params object[] values)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (selector == null) throw new ArgumentNullException("selector");
            if (!selector.Contains("new" ))
                selector = "new (" + selector + " )";
            LambdaExpression lambda = System.Linq.Dynamic.DynamicExpression.ParseLambda(source.ElementType, null, selector, values);

            return source.Provider.CreateQuery(
                Expression.Call(
                typeof(Queryable), "Select",
                new Type[] { source.ElementType, lambda.Body.Type },
                source.Expression, Expression.Quote(lambda)));
        }
        public static IQueryable Select(this IQueryable source, string selector,  Type tipo,params object[] values)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (selector == null) throw new ArgumentNullException("selector");
            if (!selector.Contains("new"))
                selector = "new (" + selector + " )";
            LambdaExpression lambda = System.Linq.Dynamic.DynamicExpression.ParseLambda(tipo, null, selector, values);

            return source.Provider.CreateQuery(
                Expression.Call(
                typeof(Queryable), "Select",
                new Type[] { tipo, lambda.Body.Type },
                source.Expression, Expression.Quote(lambda)));
        }

        public static IQueryable<T> Where<T>(this IQueryable<T> source, string predicate, params object[] values)
        {
            return (IQueryable<T>)Where((IQueryable)source, predicate, values);
        }

        public static IQueryable Where(this IQueryable source, string predicate, params object[] values)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (predicate == null) throw new ArgumentNullException("predicate");
            LambdaExpression lambda = System.Linq.Dynamic.DynamicExpression.ParseLambda(source.ElementType, typeof(bool), predicate, values);
            return source.Provider.CreateQuery(
                Expression.Call(
                    typeof(Queryable), "Where",
                    new Type[] { source.ElementType },
                    source.Expression, Expression.Quote(lambda)));
        }
        public static IEnumerable Where(this IEnumerable source, string predicate, params object[] values)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (predicate == null) throw new ArgumentNullException("predicate");
            LambdaExpression lambda = System.Linq.Dynamic.DynamicExpression.ParseLambda(source.AsQueryable().ElementType, typeof(bool), predicate, values);
            return source.AsQueryable().Provider.CreateQuery(
                Expression.Call(
                typeof(Queryable), "Where",
                new Type[] { source.AsQueryable().ElementType, lambda.Body.Type },
                source.AsQueryable().Expression,
                 Expression.Quote(lambda)));
        }
        public static IEnumerable<T> Where<T>(this IEnumerable source, string predicate, params object[] values)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (predicate == null) throw new ArgumentNullException("predicate");
            LambdaExpression lambda = System.Linq.Dynamic.DynamicExpression.ParseLambda(source.AsQueryable().ElementType, typeof(bool), predicate, values);
            return source.AsQueryable().Provider.CreateQuery(
                Expression.Call(
                typeof(Queryable), "Where",
                new Type[] { source.AsQueryable().ElementType, lambda.Body.Type },
                source.AsQueryable().Expression,
                Expression.Quote(lambda))).Cast<T>();
        }


        //OrderBy overload
        public static IOrderedEnumerable<TSource> OrderBy<TSource>(this IEnumerable<TSource> source, string propertyName)
        {
            return source.OrderBy(GetFunc<TSource>(propertyName));
        }

        //OrderBy overload
        public static IOrderedQueryable<TSource> OrderBy<TSource>(this IQueryable<TSource> source, string propertyName)
        {
            return source.OrderBy(GetExpression<TSource>(propertyName));
        }
        //OrderBy overload
        public static IOrderedEnumerable<TSource> OrderByDescending<TSource>(this IEnumerable<TSource> source, string propertyName)
        {
            return source.OrderByDescending(GetFunc<TSource>(propertyName));
        }

        //OrderBy overload
        public static IOrderedQueryable<TSource> OrderByDescending<TSource>(this IQueryable<TSource> source, string propertyName)
        {
            return source.OrderByDescending(GetExpression<TSource>(propertyName));
        }



        public static IQueryable Distinct(this IQueryable source, string selector, params object[] values)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (selector == null) throw new ArgumentNullException("selector");
            LambdaExpression lambda = System.Linq.Dynamic.DynamicExpression.ParseLambda(source.ElementType, null, selector, values);
            return source.Provider.CreateQuery(
                Expression.Call(
                    typeof(Queryable), "Distinct",
                    new Type[] { source.ElementType, lambda.Body.Type },
                    source.Expression, Expression.Quote(lambda)));
        }
        public static IQueryable GroupBy(this IQueryable source, string keySelector, string elementSelector, params object[] values)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (keySelector == null) throw new ArgumentNullException("keySelector");
            if (elementSelector == null) throw new ArgumentNullException("elementSelector");
            LambdaExpression keyLambda = System.Linq.Dynamic.DynamicExpression.ParseLambda(source.ElementType, null, keySelector, values);
            LambdaExpression elementLambda = System.Linq.Dynamic.DynamicExpression.ParseLambda(source.ElementType, null, elementSelector, values);
            return source.Provider.CreateQuery(
                Expression.Call(
                    typeof(Queryable), "GroupBy",
                    new Type[] { source.ElementType, keyLambda.Body.Type, elementLambda.Body.Type },
                    source.Expression, Expression.Quote(keyLambda), Expression.Quote(elementLambda)));
        }
        public static IQueryable Take(this IQueryable source, int count)
        {
            if (source == null) throw new ArgumentNullException("source");
            return source.Provider.CreateQuery(
                Expression.Call(
                    typeof(Queryable), "Take",
                    new Type[] { source.ElementType },
                    source.Expression, Expression.Constant(count)));
        }

        public static IQueryable Skip(this IQueryable source, int count)
        {
            if (source == null) throw new ArgumentNullException("source");
            return source.Provider.CreateQuery(
                Expression.Call(
                    typeof(Queryable), "Skip",
                    new Type[] { source.ElementType },
                    source.Expression, Expression.Constant(count)));
        }



        public static bool Any(this IQueryable source)
        {
            if (source == null) throw new ArgumentNullException("source");
            return (bool)source.Provider.Execute(
                Expression.Call(
                    typeof(Queryable), "Any",
                    new Type[] { source.ElementType }, source.Expression));
        }

        public static int Count(this IQueryable source)
        {
            if (source == null) throw new ArgumentNullException("source");
            return (int)source.Provider.Execute(
                Expression.Call(
                    typeof(Queryable), "Count",
                    new Type[] { source.ElementType }, source.Expression));
        }
        //public static int Sum(this IQueryable source)
        //{
        //    if (source == null) throw new ArgumentNullException("source");
        //    return (int)source.Provider.Execute(
        //        Expression.Call(
        //            typeof(Queryable), "Sum",
        //            new Type[] { source.ElementType }, source.Expression));
        //}
        public static object Sum(this IQueryable source, string member)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (member == null) throw new ArgumentNullException("member");

            // Properties
            PropertyInfo property = source.ElementType.GetProperty(member);
            ParameterExpression parameter = Expression.Parameter(source.ElementType, "s");
            Expression selector = Expression.Lambda(Expression.MakeMemberAccess(parameter, property), parameter);
            // We've tried to find an expression of the type Expression<Func<TSource, TAcc>>,
            // which is expressed as ( (TSource s) => s.Price );

            // Method
            MethodInfo sumMethod = typeof(Queryable).GetMethods().First(
                m => m.Name == "Sum"
                    && m.ReturnType == property.PropertyType // should match the type of the property
                    && m.IsGenericMethod);

            return source.Provider.Execute(
                Expression.Call(
                    null,
                    sumMethod.MakeGenericMethod(new[] { source.ElementType }),
                    new[] { source.Expression, Expression.Quote(selector) }));
        }

        

        public static int Average(this IQueryable source)
        {
            if (source == null) throw new ArgumentNullException("source");
            return (int)source.Provider.Execute(
                Expression.Call(
                    typeof(Queryable), "Average",
                    new Type[] { source.ElementType }, source.Expression));
        }

        public static object Average(this IQueryable source, string member)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (member == null) throw new ArgumentNullException("member");

            // Properties
            PropertyInfo property = source.ElementType.GetProperty(member);
            ParameterExpression parameter = Expression.Parameter(source.ElementType, "s");
            Expression selector = Expression.Lambda(Expression.MakeMemberAccess(parameter, property), parameter);
            // We've tried to find an expression of the type Expression<Func<TSource, TAcc>>,
            // which is expressed as ( (TSource s) => s.Price );

            // Method
            MethodInfo sumMethod = typeof(Queryable).GetMethods().First(
                m => m.Name == "Average"
                    && m.ReturnType == property.PropertyType // should match the type of the property
                    && m.IsGenericMethod);

            return source.Provider.Execute(
                Expression.Call(
                    null,
                    sumMethod.MakeGenericMethod(new[] { source.ElementType }),
                    new[] { source.Expression, Expression.Quote(selector) }));
        }
        public static Expression<Func<TSource, object>> GetExpression<TSource>(string propertyName)
        {
            var param = Expression.Parameter(typeof(TSource), "x");
            Expression conversion = Expression.Convert(Expression.Property
            (param, propertyName), typeof(object));   //important to use the Expression.Convert
            return Expression.Lambda<Func<TSource, object>>(conversion, param);
        }

        //makes deleget for specific prop
        public static Func<TSource, object> GetFunc<TSource>(string propertyName)
        {
            return GetExpression<TSource>(propertyName).Compile();  //only need compiled expression
        }

    }
}

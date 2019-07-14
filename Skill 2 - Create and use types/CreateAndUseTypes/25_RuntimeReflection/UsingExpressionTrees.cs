using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_RuntimeReflection
{
    class UsingExpressionTrees
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Calculating 3 to the power 2.");

        //    Expression<Func<double>> expressionTree = () => Math.Pow(3, 2);

        //    var operation = (MethodCallExpression) expressionTree.Body;

        //    var leftParamter = (ConstantExpression)operation.Arguments[0];
        //    var powParameter = (ConstantExpression)operation.Arguments[1];

        //    var compiledExpressionTree = expressionTree.Compile();

        //    Console.WriteLine($"Expression: () =>  {operation.Method} {leftParamter.Value} ^ {powParameter.Value} ");

        //    Console.WriteLine($"Result: {compiledExpressionTree()}");

        //    Console.Read();
        //}
    }
}

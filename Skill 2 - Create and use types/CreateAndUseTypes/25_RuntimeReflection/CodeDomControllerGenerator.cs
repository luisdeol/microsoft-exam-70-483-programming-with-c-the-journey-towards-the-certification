using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_RuntimeReflection
{
    class CodeDomControllerGenerator
    {
        //static void Main(string[] args)
        //{
        //    var controllerName = Console.ReadLine();

        //    var codeProvider = new CSharpCodeProvider();
        //    var assembly = Assembly.GetExecutingAssembly();

        //    using (var streamWriter = new StreamWriter($"{controllerName}Controller.cs", false))
        //    {
        //        var indentedTextWriter = new IndentedTextWriter(streamWriter, "    ");

        //        codeProvider.GenerateCodeFromCompileUnit(GenerateControllerCompileUnit(controllerName, assembly.GetName().Name), indentedTextWriter, new CodeGeneratorOptions());

        //        indentedTextWriter.Close();
        //    }


        //    Console.Read();
        //}

        //static CodeCompileUnit GenerateControllerCompileUnit(string controllerName, string namespaceParam)
        //{
        //    var codeCompileUnit = new CodeCompileUnit();

        //    var theNamespace = new CodeNamespace($"{namespaceParam}.Controllers");

        //    theNamespace.Imports.Add(new CodeNamespaceImport("System"));
        //    theNamespace.Imports.Add(new CodeNamespaceImport("System.Web"));
        //    theNamespace.Imports.Add(new CodeNamespaceImport("System.Web.Mvc"));

        //    var codeTypeDeclaration = new CodeTypeDeclaration($"{controllerName}Controller");
        //    var constructor = new CodeConstructor
        //    {
        //        Attributes = MemberAttributes.Public | MemberAttributes.Final
        //    };

        //    codeCompileUnit.Namespaces.Add(theNamespace);
        //    theNamespace.Types.Add(codeTypeDeclaration);
        //    codeTypeDeclaration.Members.Add(constructor);
        //    codeTypeDeclaration.BaseTypes.Add(new CodeTypeReference { BaseType = "Controller" });

        //    return codeCompileUnit;
        //}
    }
}

using _31_ValidateAppInput.Models;
using Newtonsoft.Json;
using System;
using System.Web.Script.Serialization;

namespace _31_ValidateAppInput
{
    public static class ValidateJsonData
    {
        public static void GetExample()
        {
            const string studentJson = "{\"name\": \"luis\", \"age\": 27 }";
            const string invalidStudentJson = "\"name\": \"luis\", \"age123\": 27";

            // Using JavaScriptSerializer
            var javascriptSerializer = new JavaScriptSerializer();

            try
            {
                var studentUsingJavascriptSerializer = javascriptSerializer.Deserialize<Student>(studentJson);
                var invalidStudentUsingJavaScriptSerializer = javascriptSerializer.Deserialize<Student>(invalidStudentJson);

            }
            catch (ArgumentException)
            {
                Console.WriteLine("ArgumentException for JavaScriptSerializer, invalidStudentJson!");
            }

            // Using Newtonsoft.Json
            try
            {
                var studentUsingNewtonsoft = JsonConvert.DeserializeObject<Student>(studentJson);
                var invalidStudentUsingNewtonsoft = JsonConvert.DeserializeObject<Student>(invalidStudentJson);

            }
            catch (JsonSerializationException)
            {
                Console.WriteLine("JsonSerializationException for Newtonsoft.Json, invalidStudentJson");
            }

            Console.ReadLine();
        }
    }
}

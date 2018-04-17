using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CSharp;

namespace Command
{
    public class RuntimeCompiler
    {
        public string Script { get;}
        private string OutPutFile { get; }

        public RuntimeCompiler(string script,string name)
        {
            Script = script;
            OutPutFile =  name.Replace("coocoo","dll");
        }

        public void Compile()
        {
            
            var provider = new CSharpCodeProvider();
            var parameters = new CompilerParameters();

            // Reference to System.Drawing library

            parameters.ReferencedAssemblies.Add("Command.dll");

            parameters.ReferencedAssemblies.Add("Common.dll");
            parameters.ReferencedAssemblies.Add("Newtonsoft.Json.dll");

            // True - memory generation, false - external file generation
            parameters.GenerateInMemory = false;
            // True - exe file generation, false - dll file generation
            parameters.GenerateExecutable = false;
            parameters.OutputAssembly = this.OutPutFile;// Set To plugins output
           

            var results = provider.CompileAssemblyFromSource(parameters, this.Script);

            if (results.Errors.HasErrors)
            {
                StringBuilder sb = new StringBuilder();

                foreach (CompilerError error in results.Errors)
                {
                    sb.AppendLine($"Error ({error.ErrorNumber}): {error.ErrorText}");
                }

                throw new InvalidOperationException(sb.ToString());
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Banrk_Lab.Workers
{
    class WorkersBuilder
    {
        delegate object parser(string x);

        static readonly Dictionary<string, parser> typeParsers = new Dictionary<string, parser>
        {
            { "string", (x) => x },
            { "int", (x) => Int32.Parse(x) },
            { "DateTime", (x) => DateTime.Parse(x) }
        };

        static readonly Tuple<string, parser>[] argumentsToParse = { 
            new Tuple<string, parser>("name", typeParsers["string"]),
            new Tuple<string, parser>("salary", typeParsers["int"]),
            new Tuple<string, parser>("birthday", typeParsers["DateTime"]),
            new Tuple<string, parser>("hireDate", typeParsers["DateTime"]),
        };

        static readonly string workersNamespace = "Banrk_Lab.Workers";

        static public Worker MakeWorker(string typename, Dictionary<string, string> kwargs)
        {
            var assembly = Assembly.GetExecutingAssembly();
            Type workerType = assembly.GetType(workersNamespace + "." + typename);

            object[] arguments = ParseArguments(kwargs);
            return (Activator.CreateInstance(workerType, arguments) as Worker);
        }

        static object[] ParseArguments(Dictionary<string, string> kwargs)
        {
            List<object> array = new List<object>(kwargs.Count);
            foreach (var argument in argumentsToParse)
            {
                string value;
                bool extractingSuccess = kwargs.TryGetValue(argument.Item1, out value);
                if (extractingSuccess)
                {
                    array.Add(argument.Item2(value));
                }
            }

            return array.ToArray();
        }
    }
}

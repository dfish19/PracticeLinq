using System.Collections.Generic;
using System.Linq;

List<string> colors = new List<string>() {"green", "yellow", "blue" };
colors.OrderBy(color => color.Length).ToList().ForEach(color => Console.WriteLine(color));
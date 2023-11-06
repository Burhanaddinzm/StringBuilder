using System.Text;

StringBuilder sb = new StringBuilder("Random Text");
StringBuilder sb2 = new StringBuilder("More stuff that is very important", 256);
Console.WriteLine("Capacity :{0}", sb2.Capacity);
Console.WriteLine("Length :{0}", sb.Length);

sb2.AppendLine("\nMore important text");
string bestCust = "Bob Smith";
sb2.AppendFormat("Best Customer : {0}", bestCust);
Console.WriteLine(sb2.ToString());

sb2.Replace("text", "characters");
Console.WriteLine(sb2.ToString());
sb2.Clear();

sb2.Append("Random Text");
Console.WriteLine(sb.Equals(sb2));
sb2.Insert(11, " that's great");
Console.WriteLine(sb2.ToString());

sb2.Remove(11, 7);
Console.WriteLine(sb2.ToString());

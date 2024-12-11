using System.Diagnostics;

    Stopwatch watch = new Stopwatch();
    watch.Reset();
    watch.Start();
Console.WriteLine(watch.Elapsed.ToString());
    watch.Stop();
Console.WriteLine(watch.Elapsed.ToString());

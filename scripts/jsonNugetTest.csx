#!/usr/bin/env dotnet-script

#r "nuget: Newtonsoft.Json, 12.0.3"
using Newtonsoft.Json;

public class Foo
{
    public string Bar { get; set; }
    public int Baz { get; set; }
}

var json = JsonConvert.SerializeObject(new Foo { Baz = 5, Bar = "hello" });

Console.WriteLine(json);
# noDB

Using list of objects, LINQ and SQL like string query instead of a database with `fastJSON` serializer.

## Where(string)

Using string LINQ filters:

```c#
var result = list.Where("name = \"peter\" and serial<100");

// some more examples
list.Where("serial<100").Skip(100).Take(10);
list.Where("serial<100").Orderby("name"); // ascending
list.Where("serial<100").Orderby("name desc"); // descending
list.Where("(name = \"peter\" && address = \"hill\") or (serial<100 and date.year=2000)")
```


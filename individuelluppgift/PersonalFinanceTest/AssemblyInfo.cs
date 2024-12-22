using Xunit;

//Vi stänger av parallel körning av tester så dem inte stör varandra.

[assembly: CollectionBehavior(DisableTestParallelization = true)]

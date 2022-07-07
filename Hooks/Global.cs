using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

[assembly: Parallelize(Workers = 0, Scope = ExecutionScope.ClassLevel)]

namespace TestContextIssues.Hooks
{
    [Binding]
    public class Global
    {
        
    }
}

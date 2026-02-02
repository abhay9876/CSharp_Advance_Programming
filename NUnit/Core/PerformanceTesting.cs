/*Performance Testing Using Timeout
Problem:
Create a method LongRunningTask() that sleeps for 3 seconds before returning
a result.
Use NUnit [Timeout(2000)] or MSTest [Timeout(2000)] to fail the test if the
method takes more than 2 seconds.*/
using System.Threading.Tasks;
namespace Core
{
    public class PerformanceTesting
    {
        public bool LongRunningTask()
        {
            Thread.Sleep(3000);
            return true;
        }
    }
}
/*Testing Setup and Teardown (NUnit: [SetUp] & [TearDown])
Problem:
Create a class DatabaseConnection with methods:
● Connect()
● Disconnect()
Use [SetUp] (NUnit) or [TestInitialize] (MSTest) to initialize a database
connection before each test.
Use [TearDown] (NUnit) or [TestCleanup] (MSTest) to close the connection after
each test.
Write test cases to verify that the connection is established and closed
correctly.*/

namespace Core
{
    public class DatabaseConnection
    {
        public bool IsConnect { get; set; }
        public void Connect()
        {
            IsConnect = true;
        }

        public void Disconnect()
        {
            IsConnect = false;
        }


    }
}

using WinFormsApp1;
using NUnit.Framework;
using NUnit.Framework.Legacy;
namespace TestLibrary
{
    [TestFixture]
    public class DBTests
    {
        [Test]
        public void RegAndConfirmUserCheck()
        {
            var user=new User("login","password","Джон","Лобанов","Иванович",DateTime.Now,"Ученик","11А","lol123@gmail.com");
            var check=ChangeDBData.RegisterANewUser(user);
            ChangeDBData.DeleteUser(user,"awaitingconfirmation");
            ClassicAssert.AreEqual(true, check);
            
        }
    }
}

using WinFormsApp1;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Security.Cryptography.X509Certificates;
using System;
using System.Runtime.InteropServices;
namespace TestLibrary
{
    #region Тесты Насти
    [TestFixture]
    public class NastyaTests
    {
        [Test]
        public void RightRegUserCheck()//тест для проверки регистрации двух одинаковых пользователей
        {
            var testUser=new User("test","test","test","test","test",DateTime.Now,"Ученик","11А","lol123@gmail.com");
            var check=ChangeDBData.RegisterANewUser(testUser);
            ClassicAssert.AreEqual(true, check);
            var check2=ChangeDBData.RegisterANewUser(testUser);
            ClassicAssert.AreEqual(false, check2);
            ChangeDBData.DeleteUser(testUser, "awaitingconfirmation");
        }
        [Test]
        public void ReadCurrentUserCheck()//Тест проверяет, считает ли в текущего пользователя того, кого нет в БД
        {
            var testUser = new User("test2", "test2","test2","test2","test2",DateTime.Now,"Учитель","Математика","teachermail@gmail.com");
            ChangeDBData.RegisterANewUser(testUser);
            var p=ReadFromDB.ReadCurrentUser(testUser._login,testUser._password);
            ClassicAssert.AreEqual(false, p);
            ChangeDBData.ConfirmUser(testUser);
            var p2=ReadFromDB.ReadCurrentUser(testUser._login, testUser._password);
            ChangeDBData.DeleteUser(testUser,"users");
            ClassicAssert.AreEqual(true, p2);
        }
        [Test]
        public void CheckLoginInDB()//Тест для проверки метода CheckLogin
        {
            var testUser = new User("test3", "test3", "test3", "test3", "test3", DateTime.Now, "Администратор", "", "test3@gmail.com");

            var check1_1 = ReadFromDB.CheckIfLoginOfUserInBD(testUser._login, "awaitingconfirmation");
            var check1_2 = ReadFromDB.CheckIfLoginOfUserInBD(testUser._login, "users");
            ClassicAssert.AreEqual(false,check1_1);
            ClassicAssert.AreEqual(false,check1_2);

            ChangeDBData.RegisterANewUser(testUser);
            var check2_1=ReadFromDB.CheckIfLoginOfUserInBD(testUser._login,"awaitingconfirmation");
            var check2_2 = ReadFromDB.CheckIfLoginOfUserInBD(testUser._login, "users");
            ClassicAssert.AreEqual(true, check2_1);
            ClassicAssert.AreEqual(false,check2_2);

            ChangeDBData.ConfirmUser(testUser);
            var check3_1 = ReadFromDB.CheckIfLoginOfUserInBD(testUser._login, "awaitingconfirmation");
            var check3_2 = ReadFromDB.CheckIfLoginOfUserInBD(testUser._login, "users");
            ClassicAssert.AreEqual(false, check3_1);
            ClassicAssert.AreEqual(true, check3_2);

            ChangeDBData.DeleteUser(testUser, "users");
        }
        [Test]
        public void CheckEmailInDB()//Тест для проверки метода CheckEmail
        {
            var testUser = new User("test4", "test4", "test4", "test4", "test4", DateTime.Now, "Администратор", "", "test4@gmail.com");

            var check1_1 = ReadFromDB.CheckIfEmailInBD(testUser._email, "awaitingconfirmation");
            var check1_2 = ReadFromDB.CheckIfLoginOfUserInBD(testUser._email, "users");
            ClassicAssert.AreEqual(false, check1_1);
            ClassicAssert.AreEqual(false, check1_2);

            ChangeDBData.RegisterANewUser(testUser);
            var check2_1 = ReadFromDB.CheckIfEmailInBD(testUser._email, "awaitingconfirmation");
            var check2_2 = ReadFromDB.CheckIfEmailInBD(testUser._email, "users");
            ClassicAssert.AreEqual(true, check2_1);
            ClassicAssert.AreEqual(false, check2_2);

            ChangeDBData.ConfirmUser(testUser);
            var check3_1 = ReadFromDB.CheckIfEmailInBD(testUser._email, "awaitingconfirmation");
            var check3_2 = ReadFromDB.CheckIfEmailInBD(testUser._email, "users");
            ClassicAssert.AreEqual(false, check3_1);
            ClassicAssert.AreEqual(true, check3_2);
            ChangeDBData.DeleteUser(testUser, "users");
        }
    }
    #endregion

    #region Тесты Жени
    [TestFixture]
    class ZhenyaTests
    {
        [Test] 
        public void CreateNewsTest()
        {
            //var news1 = new News();
        }
    }
    #endregion

    #region Тесты Вани
    [TestFixture]
    class VanyaTests
    {
        private Tuple<string,string> generateLoginAndEmail()
        {
            var rnd = new Random();
            const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[rnd.Next(3, 10)];
            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = alphabet[rnd.Next(alphabet.Length)];
            }
            var testLogin = new String(stringChars);
            var testEmail = testLogin+"@gmail.com";
            return Tuple.Create(testLogin, testEmail);
        }
        [Test]
        public void PressureTest()//тестирование пропускной способности регистрации и подтверждения пользователя
        {
            for(int i = 0; i < 10000; i++)
            {
                var user = new User(generateLoginAndEmail().Item1,"123","name","surname","patronymic",DateTime.Now,"Администратор","",generateLoginAndEmail().Item2);
                ChangeDBData.RegisterANewUser(user);
                ChangeDBData.ConfirmUser(user);
                ChangeDBData.DeleteUser(user, "users");
            }
        }
    }
    #endregion
}

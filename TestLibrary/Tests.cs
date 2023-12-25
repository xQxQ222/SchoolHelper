using WinFormsApp1;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Security.Cryptography.X509Certificates;
using System;
using System.Runtime.InteropServices;
using SchoolHelperApp;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Resources;
namespace TestLibrary
{
    #region Тесты Насти
    [TestFixture]
    public class NastyaTests
    {
        [Test]
        public void RightRegUserCheck()//тест для проверки регистрации двух одинаковых пользователей
        {
            var testUser=new User("testRightRegUserCheck","test","test","test","test",DateTime.Now,"Ученик","11А", "testRightRegUserCheck@gmail.com");
            var check=ChangeDBData.RegisterANewUser(testUser);
            ClassicAssert.AreEqual(true, check);
            var check2=ChangeDBData.RegisterANewUser(testUser);
            ClassicAssert.AreEqual(false, check2);
            ChangeDBData.DeleteUser(testUser, "awaitingconfirmation");
        }
        
        [Test]
        public void CheckLoginInDB()//Тест для проверки метода CheckLogin
        {
            var testUser = new User("testCheckLoginInDB", "test3", "test3", "test3", "test3", DateTime.Now, "Администратор", "", "testCheckLoginInDB@gmail.com");

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
            var testUser = new User("testCheckEmailInDB", "test4", "test4", "test4", "test4", DateTime.Now, "Администратор","", "testCheckEmailInDB@gmail.com");

            var check1_1 = ReadFromDB.CheckIfEmailInBD(testUser._email, "awaitingconfirmation");
            var check1_2 = ReadFromDB.CheckIfLoginOfUserInBD(testUser._email, "users");
            ClassicAssert.AreEqual(false, check1_1);
            ClassicAssert.AreEqual(false, check1_2);
            ChangeDBData.DeleteUser(testUser, "awaitingconfirmation");

            ChangeDBData.RegisterANewUser(testUser);
            var check2_1 = ReadFromDB.CheckIfEmailInBD(testUser._email, "awaitingconfirmation");
            var check2_2 = ReadFromDB.CheckIfEmailInBD(testUser._email, "users");
            ClassicAssert.AreEqual(true, check2_1);
            ClassicAssert.AreEqual(false, check2_2);

            ChangeDBData.ConfirmUser(testUser);
            var check3_1 = ReadFromDB.CheckIfEmailInBD(testUser._email, "awaitingconfirmation");
            var check3_2 = ReadFromDB.CheckIfEmailInBD(testUser._email, "users");
            ChangeDBData.DeleteUser(testUser, "users");
            ClassicAssert.AreEqual(false, check3_1);
            ClassicAssert.AreEqual(true, check3_2);
            
        }

        [Test]
        public void ToStringNewsCheck()
        {
            var news = new News("Ироденко А. А.", "Тестовая новость", null);
            ClassicAssert.AreEqual("Новость\nАвтор: Ироденко А. А.\nТекст новости: Тестовая новость",news.ToString());
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
            var news1 = new News("Женя","Новость", WorkWithImages.ImageToByteArray(null));
            ChangeDBData.CreateNews(news1);
            var newsList = ReadFromDB.GetNewsFromDB();
            ClassicAssert.AreEqual(newsList[newsList.Length-1].author,"Женя");
            ChangeDBData.DeleteNews(newsList[newsList.Length - 1]);

        }
        
        [Test]
        public void ToStringUserTest()
        {
            var tempUser = new User("test", "test","Евгения","Токарева","Александровна",DateTime.Now,"Ученик","11А","zhenyatokareva@gmail.com");
            ClassicAssert.AreEqual("ФИО: Токарева Е. А.\nСтатус:Ученик (11А)",tempUser.ToString());
        }
        [Test]
        public void CheckUserLoggedSuccessful()//Тест проверяет, считает ли в текущего пользователя того, кого нет в БД
        {
            var testUser = new User("testCheckUserLoggedSuccessful", "test2", "test2", "test2", "test2", DateTime.Now, "Учитель", "Математика", "testCheckUserLoggedSuccessful@gmail.com");
            ChangeDBData.RegisterANewUser(testUser);
            var p = ReadFromDB.ReadCurrentUser(testUser._login, testUser._password);
            ClassicAssert.AreEqual(false, p);
            ChangeDBData.ConfirmUser(testUser);
            var p2 = ReadFromDB.ReadCurrentUser(testUser._login, testUser._password);
            ChangeDBData.DeleteUser(testUser, "users");
            ClassicAssert.AreEqual(true, p2);
        }
        [Test]
        public void AddMessageToBDTest()
        {
            var testUser1 = new User("testMessage1", "test1", "test1", "test1", "test1", DateTime.Now, "Учитель", "Математика", "testMessage1@gmail.com");
            ChangeDBData.RegisterANewUser(testUser1);
            ChangeDBData.ConfirmUser(testUser1);
            var testUser2 = new User("testMessage2", "test2", "test2", "test2", "test2", DateTime.Now, "Учитель", "Математика", "testMessage2@gmail.com");
            ChangeDBData.RegisterANewUser(testUser2);
            ChangeDBData.ConfirmUser(testUser2);
            var message=new ChatMessage(testUser1._login,testUser2._login,"Привет!");
            ChangeDBData.AddNewMessage(message);
            var messagesTestUser1Received = ReadFromDB.GetMessages(testUser1);
            var messagesTestUser2Received= ReadFromDB.GetMessages(testUser2);
            ChangeDBData.DeleteUser(testUser2,"users");
            ChangeDBData.DeleteUser(testUser1,"users");

            //ClassicAssert.AreEqual(testUser1._login, messagesTestUser2Received[0].sender);
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
        public void UsersPressureTest()//тестирование пропускной способности регистрации и подтверждения пользователя
        {
            for(int i = 0; i <10000; i++)
            {
                var user = new User(generateLoginAndEmail().Item1,"123","name","surname","patronymic",DateTime.Now,"Администратор","",generateLoginAndEmail().Item2);
                ChangeDBData.RegisterANewUser(user);
                ChangeDBData.ConfirmUser(user);
                var curretn = ReadFromDB.ReadCurrentUser(user._login, user._password);
                ClassicAssert.AreEqual(true, curretn);
                ChangeDBData.DeleteUser(user, "awaitingconfirmation");
                ChangeDBData.DeleteUser(user, "users");
            }
        }
        [Test]
        public void NewsCreatePressureTest()//Тестирование пропускной способности создания новостей
        {
            for (int i = 0; i < 20; i++)
            {
                var generatedName = generateLoginAndEmail().Item1;
                var news1 = new News(generatedName, "Новость", WorkWithImages.ImageToByteArray(null));
                ChangeDBData.CreateNews(news1);
                var newsList = ReadFromDB.GetNewsFromDB();
                ClassicAssert.AreEqual(newsList[newsList.Length - 1].author, generatedName);
                ChangeDBData.DeleteNews(newsList[newsList.Length - 1]);
            }
        }
        [Test]
        public void DeleteNonExistentUser()//Тест проверяющий сценарий удаления пользователя, отсутствующего в базе данных
        {
            var testUser = new User("testDeleteNonExistentUser", "test", "test", "test", "test", DateTime.Now, "Ученик", "11А", "testDeleteNonExistentUser@gmail.com");
            var check=ChangeDBData.DeleteUser(testUser,"users");
            ClassicAssert.AreEqual(false, check);
        }
        [Test]
        public void CheckCurrentUser()
        {
            var testUser = new User("testCheckCurrentUser", "test2", "test2", "test2", "test2", DateTime.Now, "Учитель", "Математика", "testCheckCurrentUser@gmail.com");
            ChangeDBData.RegisterANewUser(testUser);
            ReadFromDB.ReadCurrentUser(testUser._login, testUser._password);
            Assert.That(User.Current._login, !Is.EqualTo(testUser._login));
            ChangeDBData.ConfirmUser(testUser);
            ReadFromDB.ReadCurrentUser(testUser._login, testUser._password);
            ClassicAssert.AreEqual(User.Current._login, testUser._login);
            ChangeDBData.DeleteUser(testUser, "users");
        }
    }
    #endregion
}

using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WinFormsApp1
{
    public class ChangeDBData
    {
        public static bool RegisterANewUser(User userToReg) 
        {
            bool userSuccessfullyregistered;
            if (ReadFromDB.CheckIfLoginOfUserInBD(userToReg._login,"users") || ReadFromDB.CheckIfEmailInBD(userToReg._email,"users")|| 
                ReadFromDB.CheckIfLoginOfUserInBD(userToReg._login, "awaitingconfirmation") 
                || ReadFromDB.CheckIfEmailInBD(userToReg._email, "awaitingconfirmation"))
            {
                MessageBox.Show("Пользователь с таким логином или E-mail уже существует");
                return false;
            }
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `awaitingconfirmation` (`login`, `password`, `name`, `surname`, `patronymic`, `birthdate`, `status`, `additionalParameter`, `email`) VALUES (@log,@pass,@name,@surname,@otch,@birthDate,@status,@additionalParameter,@email);", db.getConnection());

            command.Parameters.Add("@log", MySqlDbType.VarChar).Value = userToReg._login;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = userToReg._password;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value  = userToReg._name;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = userToReg._surename;
            command.Parameters.Add("@otch", MySqlDbType.VarChar).Value  = userToReg._patronymic;
            command.Parameters.Add("@birthDate", MySqlDbType.Date).Value = userToReg._Date;
            command.Parameters.Add("@status", MySqlDbType.VarChar).Value = userToReg._status;
            command.Parameters.Add("@additionalParameter", MySqlDbType.VarChar).Value = userToReg._additionalParameter;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = userToReg._email;

            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
                userSuccessfullyregistered = true;
            else
            {
                userSuccessfullyregistered = false;
            }
            db.closeConnection();
            return userSuccessfullyregistered;
        }

        public static void ChangePass(string email, string newPass)
        {
            DB db = new DB();
            DataTable dt = new DataTable();
            MySqlCommand command = new MySqlCommand("UPDATE `users` SET `password` = @uP WHERE `users`.`email` LIKE @email", db.getConnection());
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email; 
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = newPass; 
            db.openConnection();
            MessageBox.Show("Пароль успешно изменен");
            command.ExecuteNonQuery();
            db.closeConnection();
        }

        public static void AddNewMessage(Tuple<List<string>, Dictionary<string, string>> recip, string comboBox1, string richTextBox1)
        {
            DB dB = new DB();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `messages` (`sender`, `recipient`, `message`, `messageDate`) VALUES (@sender, @recipient, @message, @messageDate)", dB.getConnection());
            cmd.Parameters.Add("@sender", MySqlDbType.VarChar).Value = User.Current._login;
            cmd.Parameters.Add("@recipient", MySqlDbType.VarChar).Value = recip.Item2[comboBox1];
            cmd.Parameters.Add("@message", MySqlDbType.Text).Value = richTextBox1;
            cmd.Parameters.Add("@messageDate", MySqlDbType.Date).Value = DateTime.Now;
            dB.openConnection();
            cmd.ExecuteNonQuery();
            dB.closeConnection();
        }

        public static void ConfirmUser(User userToConfirm)
        {
            ChangeDBData.DeleteUser(userToConfirm, "awaitingconfirmation");
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`, `name`, `last name`, `otchestvo`, `birthdate`, `status`, `additionalParameter`, `email`) VALUES (@log,@pass,@name,@surname,@otch,@birthDate,@status,@additionalParameter,@email);", db.getConnection());

            command.Parameters.Add("@log", MySqlDbType.VarChar).Value = userToConfirm._login;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = userToConfirm._password;
            command.Parameters.Add("@name", MySqlDbType.Text).Value = userToConfirm._name;
            command.Parameters.Add("@surname", MySqlDbType.Text).Value = userToConfirm._surename;
            command.Parameters.Add("@otch", MySqlDbType.VarChar).Value = userToConfirm._patronymic;
            command.Parameters.Add("@birthDate", MySqlDbType.Date).Value = userToConfirm._Date;
            command.Parameters.Add("@status", MySqlDbType.Text).Value = userToConfirm._status;
            command.Parameters.Add("@additionalParameter", MySqlDbType.VarChar).Value = userToConfirm._additionalParameter;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = userToConfirm._email;

            db.openConnection();
            command.ExecuteNonQuery();
            db.closeConnection();
        }
        public static void CreateNews(News news)
        {
            DB dB = new DB();
            MySqlCommand command= new MySqlCommand("INSERT INTO `news` (`author`, `text`, `Image`) VALUES (@author, @text,@image)", dB.getConnection());
            command.Parameters.Add("@author", MySqlDbType.VarChar).Value = news.author;
            command.Parameters.Add("@text", MySqlDbType.Text).Value = news.text;
            command.Parameters.Add("@image", MySqlDbType.Blob).Value = news.image;
            dB.openConnection();
            command.ExecuteNonQuery();
            dB.closeConnection();
        }
        public static void DeleteUser(User userToDelete,string table)
        {
            DB dB=new DB();
            MySqlCommand command=new MySqlCommand($"DELETE FROM `{table}` WHERE `{table}`.`login` LIKE @uL", dB.getConnection());
            command.Parameters.Add("@uL",MySqlDbType.VarChar).Value=userToDelete._login;
            dB.openConnection();
            command.ExecuteNonQuery();
            dB.closeConnection();
        }
    }
}

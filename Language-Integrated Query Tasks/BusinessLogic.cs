using System;
using System.Collections.Generic;
using System.Linq;


namespace Language_Integrated_Query_Tasks
{
    class BusinessLogic
    {
        public List<User> users = new List<User>();
        public List<Record> records = new List<Record>();
        public BusinessLogic()
        {
            //Наполняем юзеров
            users.Add(new User(1, "Роман", "Петров"));
            users.Add(new User(2, "Санек", "Петров"));
            users.Add(new User(3, "Илья", "Мишуров"));
            users.Add(new User(4, "Санек", "Смирнов"));
            users.Add(new User(5, "Федос", "Жилкин"));

            //Наполняем репликами
            records.Add(new Record(users[2], "Что по матану?"));
            records.Add(new Record(users[3], "Привет! Не в курсе."));
            records.Add(new Record(users[3], "Давай спросим у старосты."));
            records.Add(new Record(users[4], "Так ты же староста."));
            records.Add(new Record(users[0], "Неудачно получилось."));
            records.Add(new Record(users[1], "Что ж, такое бывает."));

        }

        //LINQ запросы:
        public List<User> GetUsersBySurname(String surname)
        {
            return (from user in users where user.Surname == surname select user).ToList();
        }

        public User GetUserByID(int id)
        {
            return (from user in users where user.ID == id select user).Single();
        }

        public List<User> GetUsersBySubstring(String substring)
        {
            return (from user in users where user.Name.Contains(substring) || user.Surname.Contains(substring) select user).ToList();
        }

        public List<String> GetAllUniqueNames()
        {
            return (from user in users select user.Name).Distinct().ToList();
        }

        public List<User> GetAllAuthors()
        {
            return (from record in records select record.Author).Distinct().ToList();
        }

        public Dictionary<int, User> GetUsersDictionary()
        {
            var keys = new List<int> { 1, 2, 3, 4, 5 };
            return keys.Zip(users, (k, v) => new { Key = k, Value = v }).ToDictionary(x => x.Key, x => x.Value);
        }

        public int GetMaxID()
        {
            var MaxIDuser = users.OrderByDescending(i => i.ID);
            return (from user in MaxIDuser select user.ID).ToList().First();
        }

        public List<User> GetOrderedUsers()
        {
            return users.OrderBy(i => i.Name).ToList();
        }

        public List<User> GetDescendingOrderedUsers()
        {
            return users.OrderByDescending(i => i.Name).ToList();
        }

        public List<User> GetReversedUsers()
        {
            return users.OrderBy(i => i.Name).Reverse().ToList();
        }

        public List<User> GetUsersPage(int pageSize, int pageIndex)
        {
            return users.Skip(pageIndex * pageSize).Take(pageSize).ToList();
        }
    }
}


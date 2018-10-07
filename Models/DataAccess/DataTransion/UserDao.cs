namespace Models.DataAccess.Transion
{
    using DataTransion.Dto;
    using EntityFramework;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class UserDao
    {
        private ShopDbContext db = null;
        public UserDao()
        {
            db = new ShopDbContext();
        }

        // Get List All Object
        public List<User> GetObjectList()
        {
            return db.Users.ToList();
        }

        // Get List Object By User Grant
        public List<User> GetObjectList(int grant)
        {
            return db.Users.Where(u => u.GrantID == grant).ToList();
        }

        // Find Object By Primary key
        public User GetObject(UserDto dto)
        {
            return db.Users.SingleOrDefault(obj => obj.UserName == dto.UserName);
        }

        // Check Exist Object
        public bool HasObject(UserDto dto)
        {
            return db.Users.Count(obj => obj.UserName == dto.UserName) > 0 ? true : false;
        }

        // using store procedure to get data list of Student
        public List<User> GetObjectList(string proc, object[] parameter)
        {
            return db.Database.SqlQuery<User>(proc, parameter).ToList();
        }

        public void AddObject(UserDto dto)
        {
            var entity = new User()
            {
                // TODO
                // ....
                CreateAt = DateTime.Now,
                UpdateAt = DateTime.Now
            };
            db.Users.Add(entity);
            db.SaveChanges();
        }

        public bool UpdateObject(UserDto dto)
        {
            if (!HasObject(dto))
                return false;
            var entity = GetObject(dto);
            // TODO
            // ...
            db.SaveChanges();
            return true;
        }

        // Check reference to orther tables
        public bool HasRef(User obj)
        {
            // TODO
            // ...
            return true;
        }

        public bool DeleteObject(UserDto dto)
        {
            if (!HasObject(dto))
                return false;
            var entity = GetObject(dto);
            if (HasRef(entity))
                return false;
            db.Users.Remove(entity);
            db.SaveChanges();
            return true;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoupRepository;
using YoupService.Models;

namespace YoupService
{
    public class UserService
    {
        public UserS GetUser(Guid id)
        {
            UserS user = new UserS();
            YoupData dataContext = new YoupData();

            user = ConvertService.ToService(dataContext.GetUser(id));

            return user;
        }

        public List<UserS> GetUsers()
        {
            List<UserS> users = new List<UserS>();
            YoupData dataContext = new YoupData();

            users = ConvertService.ToService(dataContext.GetUsers());

            return users;
        }

        public void CreateUser(UserS user)
        {
            YoupData dataContext = new YoupData();
            User _user = ConvertService.FromService(user);

            dataContext.CreateUser(_user);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public interface IFacebookApplication
    {
        void Run();

        void Login();

        void Logout();
    }
}

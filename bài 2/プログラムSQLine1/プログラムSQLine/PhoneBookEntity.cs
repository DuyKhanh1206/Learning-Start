﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace プログラムSQLine
{
    class PhoneBookEntity
    {
        public int UserId { get; }
        public string UserName { get; }
        public int PhoneId { get; }
        public string PhoneNumber { get; }

        public PhoneBookEntity(int userid, string username, int phoneid, string phonenumber)
            {
                UserId = userid;
                UserName = username;
                PhoneId = phoneid;
                PhoneNumber = phonenumber;

            }
    }
}

﻿using Disbott;
using Disbott.Controllers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisbottUnitTests.MessageCount
{
    [TestFixture]
    public class MessageCountOperations
    {
        [Test]
        public void Can_Get_MessageCount_Check()
        {
            File.Delete(Constants.MessageCountPath);

            

        }
    }
}

﻿/*
 * Copyright 2015 Mikhail Shiryaev
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *     http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 * 
 * 
 * Product  : Rapid SCADA
 * Module   : SCADA-Server Console Application for Mono .NET framework
 * Summary  : The main entry point for the application
 * 
 * Author   : Mikhail Shiryaev
 * Created  : 2015
 * Modified : 2015
 */

using Scada.Server.Svc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scada.Server.Mono
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting SCADA-Server");
            Manager manager = new Manager();
            manager.StartService();
            Console.WriteLine("SCADA-Server started. Press 'x' to exit.");

            while (Console.ReadKey().KeyChar != 'x') { }
            manager.StopService();
        }
    }
}
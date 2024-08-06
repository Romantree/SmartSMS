using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carriage_SMS_Project.COMMON
{ 
        public class Singleton
        {
            private static Singleton instance;
            private static readonly object lockObj = new object();

            private Singleton() { }

            public static Singleton Instance
            {
                get
                {
                    lock (lockObj)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                        }
                        return instance;
                    }
                }
            }
        }

    }


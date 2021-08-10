using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MTCWebshop.Domain
{
    public enum Status { 
                        Reserved = 1,
                        InProgress = 2,
                        Done = 4, 
                        Cancelled=8, 
                        Blocked=16,
                        Dilevered=32,
                        Undelivrable=64,
                        Returned=128,
                        OnRoad=256
    }
    public enum Reason  {
                        WrongProduct=1,
                        Broken=2
                        }
    public static class Global
    {
        
    }
}

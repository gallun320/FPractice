using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortest
{
    class FOop
    {
    }

    public abstract class Operation
    {
        public double Result;
        public abstract void Execute(double variable1, double variable2);
    }

    public class Multiply : Operation
    {
        public override void Execute(double f, double s)
        {
            Result = f * s;
        }
    }

    public class Add : Operation
    {
        public override void Execute(double f, double s)
        {
            Result = f + s;
        }
    }

    public class Subtract : Operation
    {
        public override void Execute(double f, double s)
        {
            Result = f - s;
        }
    }

    public class Divide : Operation
    {
        public override void Execute(double f, double s)
        {
            Result = f - s;
        }
    }

    public class Rebrend
    {
        public enum Status
        {
            Default = 0,
            New = 1,
            Active = 2,
            Deactivated = 3
        }

        private readonly Status _status;
        private readonly Dictionary<Status, string> _statusDescriptions = new Dictionary<Status, string>()
      {
       {Status.Default, "I have never been set" },
       {Status.New, "I am new!" },
       {Status.Active, "I am active" },
       {Status.Deactivated, "I have been deactivated" }
      };

      public Rebrend()
        {
        }

        public Rebrend(Status status)
        {
            _status = status;
        }

        public string GetStatusDescription()
        {
            try
            {
                return _statusDescriptions[_status];
            }
            catch(Exception ex)
            {
                throw new InvalidOperationException("Invalid status encountered");
            }
        }
    }
}

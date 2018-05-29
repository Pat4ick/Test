#region Strategy Interface

using System;
using System.Collections.Generic;

public enum ePassengerTitle
{
    Mr,
    Mrs,
    Doctor,
}

class Program
{
    static void Main(string[] args)
    {
        ePassengerTitle title = ePassengerTitle.Doctor;
        Context.DoAlgorithm(title);
    }
}



public interface IPassengerTitleStrategy
{
    void DoAlgorithm();
}

#endregion

#region Concrete Classes

public class MrPassengerTitleStrategy : IPassengerTitleStrategy
{
    #region IPassengerTitleStrategy Members

    public void DoAlgorithm()
    {
        throw new NotImplementedException();
    }

    #endregion
}

public class MrsPassengerTitleStrategy : IPassengerTitleStrategy
{
    #region IPassengerTitleStrategy Members

    public void DoAlgorithm()
    {
        throw new NotImplementedException();
    }

    #endregion
}

public class DoctorPassengerTitleStrategy : IPassengerTitleStrategy
{
    #region IPassengerTitleStrategy Members

    public void DoAlgorithm()
    {
        throw new NotImplementedException();
    }

    #endregion
}

#endregion

#region Context

public class Context
{
    #region Members

    private static Dictionary<ePassengerTitle, IPassengerTitleStrategy> _strategies =
        new Dictionary<ePassengerTitle, IPassengerTitleStrategy>();

    #endregion

    #region Ctor

    static Context()
    {
        _strategies.Add(ePassengerTitle.Mr, new MrPassengerTitleStrategy());
        _strategies.Add(ePassengerTitle.Mrs, new MrsPassengerTitleStrategy());
        _strategies.Add(ePassengerTitle.Doctor, new DoctorPassengerTitleStrategy());
    }

    #endregion

    #region Methods

    public static void DoAlgorithm(ePassengerTitle title)
    {
        _strategies[title].DoAlgorithm();
    }

    #endregion
}

#endregion

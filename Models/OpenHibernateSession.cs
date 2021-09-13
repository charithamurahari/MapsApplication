using NHibernate;
using NHibernate.Cfg;

namespace MapsApplication.Models
{
    public class OpenHibernateSession
    {
        private static ISessionFactory _sessionFactory;

        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    var configuration = new Configuration();
                    configuration.Configure();
                    configuration.AddAssembly(typeof(AddLocation).Assembly);
                    _sessionFactory = configuration.BuildSessionFactory();
                }
                return _sessionFactory;
            }
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }

        public class LocationRepo
        {
            public void Add(AddLocation addLocation)
            {
                using (ISession session = OpenHibernateSession.OpenSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Save(addLocation);
                        transaction.Commit();
                    }
                }
            }
            public AddLocation GetLocationName(string Name)
            {
                AddLocation addLocation = new AddLocation();
                using (ISession session = OpenHibernateSession.OpenSession())
                {
                    addLocation = session.Get<AddLocation>(Name);
                }
                return addLocation;
            }
            }
        }
}

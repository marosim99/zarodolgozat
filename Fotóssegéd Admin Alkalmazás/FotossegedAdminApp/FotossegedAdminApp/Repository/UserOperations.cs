using Fotosseged.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FotossegedAdminApp.Repository
{
    class UserOperations
    {
        private Felhasznalok users;

        public UserOperations(Felhasznalok users)
        {
            this.users = users;
        }

        internal Felhasznalok getModositottFelhasznalok()
        {
            return users;
        }
    }
}

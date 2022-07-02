using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Controllers
{
    public class UserCtrl
    {
        public UserCtrl() { }
        public UserCtrl(Model.Class.User user)
        {
            //Model.Method.Conection.Open();
            /*using (var ctx = new ContextoEntity)
            {

                ctx.User.Add(user); 
                ctx.SaveChanges();
            }*/
            //Model.Method.Conection.Close();
        }



    }
}

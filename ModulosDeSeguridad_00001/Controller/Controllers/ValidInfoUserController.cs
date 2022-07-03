using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Controllers
{
    public class ValidInfoUserController
    {
        public bool validated { get; private set; }
        public ValidInfoUserController()
        {

        }
        public ValidInfoUserController(int TypeValidation, int Propertie, string validating)
        {
            var valid = new Model.Method.ValidInfoUser(TypeValidation, Propertie, validating);
            validated = valid.validated;
        }
    }
}

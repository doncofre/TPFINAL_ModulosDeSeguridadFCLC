using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Model.Method
{
    public class ValidInfoUser
    {
        public bool validated { get; private set; }
        public ValidInfoUser()
        {
            //YA VENGO ME FUI A COMPRAR UNA PIZZA
        }
        public ValidInfoUser(int validtype, int propertie, string data) //validtype is an enum converted to int, same to propertie
        { //CHANGE METHOD TO BOOL 

            switch (validtype)
            {
                case 0:                         //check in database
                    switch (propertie)
                    {
                        case 0:


                            break;

                        case 1:


                            break;

                        case 2:
                            //validated = validateDNIDDBB(data);

                            break;

                        case 3:
                            //validated = validateEmailDDBB(data);

                            break;

                        case 4:
                            //validated = validateUserDDBB(data);

                            break;

                        case 5:


                            break;

                        case 6:


                            break;

                        default:


                            break;

                    }

                    break;

                case 1:                                     //check the string  

                    switch (propertie)
                    {
                        case 0:
                            validated = ValidateNames(data);
                            break;

                        case 1:
                            validated = ValidateNames(data);
                            break;

                        case 2:
                            bool ValidatedDNI = ValidateDNI(data);
                            break;

                        case 3:
                            validated = ValidateEmail(data);
                            break;
                        case 4:
                            validated = ValidateUser(data);
                            //return ValidatedUser;
                            break;

                        case 5:
                            validated = ValidatePassword(data);

                            break;

                        case 6:
                            //bool ValidatedBirth = ValidateBirth(data);

                            break;

                        default:


                            break;

                    }

                    break;

                default:


                    break;
            }



        }
        public bool ValidateNames(string name)
        {
            bool IsIntString = name.Any(char.IsDigit);
            bool OnlyLetters = Regex.IsMatch(name, @"^[a-zA-Z]+$");
            if (name == null)
            {
                return false;

            }
            if (IsIntString == false && OnlyLetters == true && name.Length > 2)
            {

                return true;

            }
            else
            {
                return false;
            }
        }
        public bool ValidateDNI(string DNI)
        {
            bool IsInt = int.TryParse(DNI, out int value);
            if (IsInt == true)
            {

                if (value > 1000000 && value < 99999999)
                {
                    return true;
                }

            }
            return false;

        }
        public bool ValidateUser(string user)
        {
            bool OnlyLettersNumersANDUnderscore = Regex.IsMatch(user, @"^[a-zA-Z0-9_]+$");
            if (user == null)
            {
                return false;

            }
            if (OnlyLettersNumersANDUnderscore == true && user.Length > 2)
            {

                return true;

            }
            else
            {
                return false;
            }
        }
        public bool ValidatePassword(string user)
        {
            bool OnlyLettersNumersANDUnderscore = Regex.IsMatch(user, @"^[a-zA-Z0-9_]+$");
            if (user == null)
            {
                return false;

            }
            if (OnlyLettersNumersANDUnderscore == true && user.Length > 2)
            {

                return true;

            }
            else
            {
                return false;
            }
        }
        public bool ValidateEmail(string Email)
        {
            //bool OnlyLettersNumersANDUnderscore = Regex.IsMatch(user, @"^[a-zA-Z0-9_]+$");
            char AtSign = '@';        // cofre.le      @       gmail          .            com
            string[] EmailSplit = Email.Split(AtSign);
            bool OnlyLettersNumersANDUnderscoreLeft = Regex.IsMatch(EmailSplit[0], @"^[a-zA-Z0-9_]+$");
            bool OnlyLettersNumersANDUnderscoreRight = false;
            try
            {
                OnlyLettersNumersANDUnderscoreRight = Regex.IsMatch(EmailSplit[1], @"^[a-zA-Z0-9_]+$");
            }
            catch (Exception) { return false; }
            if (EmailSplit.Length != 2)
            {
                return false;
            }
            if (EmailSplit.Length == 2)
            {
                if (OnlyLettersNumersANDUnderscoreLeft == true && OnlyLettersNumersANDUnderscoreRight == true)
                {
                    string[] EmailRightSplit = EmailSplit[1].Split('.');
                    if (EmailRightSplit.Length > 1)
                    {
                        return true;
                    }
                    return false;
                }
                return false;
            }
            return false;

        }

        /*public bool validateEmailDDBB (string parameter)
        {
            using (var ctx = new entity() )
            {
                var exists = ctx.Users.Where(x => x.Email == parameter).FirstOrDefault();
                if (exists == null)
                {
                    return false;
                }
                else
                { 
                    return true;
                }
            }
        }
        public bool validateDNIDDBB(string parameter)
        {
            using (var ctx = new entity())
            {
                var exists = ctx.Users.Where(x => x.DNI == parameter).FirstOrDefault();
                if (exists == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        public bool validateUserDDBB(string parameter)
        {
            using (var ctx = new entity())
            {
                var exists = ctx.Users.Where(x => x.User == parameter).FirstOrDefault();
                if (exists == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }*/







    }
}

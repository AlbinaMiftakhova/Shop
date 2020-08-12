using System;
using System.Web.Mvc;
using System.Web.Security;
using Shop.Models;

namespace Shop.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/LogOn
        public ActionResult LogOn()
        {
            return View();
        }

        //
        // POST: /Account/LogOn
        [HttpPost]
        public ActionResult LogOn(LogOnModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                if (Membership.ValidateUser(model.UserName, model.Password))
                {
                    MigrateShoppingCart(model.UserName);

                    FormsAuthentication.SetAuthCookie(model.UserName,
                        model.RememberMe);
                    if (Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1
                        && returnUrl.StartsWith("/")
                        && !returnUrl.StartsWith("//") &&
                        !returnUrl.StartsWith("/\\"))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Неверный пароль или имя пользователя.");
                }
            }
            return View(model);
        }

        //
        // GET: /Account/LogOff
        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("Index", "Home");
        }

        //
        // GET: /Account/Register
        public ActionResult Register()
        {
            return View();
        }

        //
        // POST: /Account/Register
        [HttpPost]
        public ActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                MembershipCreateStatus createStatus;
                Membership.CreateUser(model.UserName, model.Password, model.Email,
                       "question", "answer", true, null, out
                       createStatus);

                if (createStatus == MembershipCreateStatus.Success)
                {
                    MigrateShoppingCart(model.UserName);

                    FormsAuthentication.SetAuthCookie(model.UserName, false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", ErrorCodeToString(createStatus));
                }
            }
            return View(model);
        }

        //
        // GET: /Account/ChangePassword
        [Authorize]
        public ActionResult ChangePassword()
        {
            return View();
        }

        //
        // POST: /Account/ChangePassword
        [Authorize]
        [HttpPost]
        public ActionResult ChangePassword(ChangePasswordModel model)
        {
            if (ModelState.IsValid)
            {
                bool changePasswordSucceeded;
                try
                {
                    MembershipUser currentUser = Membership.GetUser(User.Identity.Name, true);
                    changePasswordSucceeded = currentUser.ChangePassword(model.OldPassword, model.NewPassword);
                }
                catch (Exception)
                {
                    changePasswordSucceeded = false;
                }

                if (changePasswordSucceeded)
                {
                    return RedirectToAction("ChangePasswordSuccess");
                }
                else
                {
                    ModelState.AddModelError("", "Текущий пароль неверен либо новый пароль не соответсвует требованиям.");
                }
            }
            return View(model);
        }

        //
        // GET: /Account/ChangePasswordSuccess
        public ActionResult ChangePasswordSuccess()
        {
            return View();
        }

        private void MigrateShoppingCart(string UserName)
        {
            var cart = ShoppingCart.GetCart(this.HttpContext);
            cart.MigrateCart(UserName);
            Session[ShoppingCart.CartSessionKey] = UserName;
        }

        #region Status Codes
        private static string ErrorCodeToString(MembershipCreateStatus createStatus)
        {
            switch (createStatus)
            {
                case MembershipCreateStatus.DuplicateUserName:
                    return "Такое имя уже существует. Выберите другое имя";

                case MembershipCreateStatus.DuplicateEmail:
                    return "Этот адрес электронной почты уже используется. Выберите другой адрес электронной почты.";

                case MembershipCreateStatus.InvalidPassword:
                    return "Предложенный пароль не соответствует требованиям. Введите корректный пароль.";

                case MembershipCreateStatus.InvalidEmail:
                    return "Предложенный адрес электронной почты не соответсвует требованиям. Проверьте правильность введенных данных.";

                case MembershipCreateStatus.InvalidAnswer:
                    return "Предложенный ответ не соответствует требованиям. Проверьте правильность введенных данных.";

                case MembershipCreateStatus.InvalidQuestion:
                    return "Предложенный вопрос не соответствует требованиям. Проверьте правильность введенных данных.";

                case MembershipCreateStatus.InvalidUserName:
                    return "Предложенное имя пользователя не соответствует требованиям. Проверьте правильность введенных данных.";

                case MembershipCreateStatus.ProviderError:
                    return "Поставщик аутентификации возвратил ошибку. Пожалуйста, проверьте правильность данных и попробуйте еще раз. Если проблема не устранена, обратитесь к системному администратору.";

                case MembershipCreateStatus.UserRejected:
                    return "Запрос на создание учетной записи был отменен. Пожалуйста, проверьте правильность данных и попробуйте еще раз. Если проблема не устранена, обратитесь к системному администратору.";

                default:
                    return "Произошла неизвестная ошибка. Пожалуйста, проверьте правильность данных и попробуйте еще раз. Если проблема не устранена, обратитесь к системному администратору.";
            }
        }
        #endregion
    }
}
